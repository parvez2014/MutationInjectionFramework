//
// ParameterNotUsedIssue.cs
//
// Author:
//      Mansheng Yang <lightyang0@gmail.com>
//
// Copyright (c) 2012 Mansheng Yang <lightyang0@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using ICSharpCode.NRefactory.Semantics;
using System.Linq;
using ICSharpCode.NRefactory.TypeSystem;
using System.Collections.Generic;
using ICSharpCode.NRefactory.CSharp.Resolver;
using System;

namespace ICSharpCode.NRefactory.CSharp.Refactoring
{
[IssueDescription ("Unused parameter",
                   Description = "Parameter is never used.",
                   Category = IssueCategories.Redundancies,
                   Severity = Severity.Warning,
                   IssueMarker = IssueMarker.GrayOut)]
public class ParameterNotUsedIssue : ICodeIssueProvider
{
    #region ICodeIssueProvider implementation
    public IEnumerable<CodeIssue> GetIssues(BaseRefactoringContext context)
    {
        var delegateVisitor = new GetDelgateUsagesVisitor (context);
        context.RootNode.AcceptVisitor (delegateVisitor);

        return new GatherVisitor (context, delegateVisitor).GetIssues ();
    }
    #endregion

    // Collect all methods that are used as delegate
    class GetDelgateUsagesVisitor : DepthFirstAstVisitor
    {
        BaseRefactoringContext ctx;
        public readonly List<IMethod> UsedMethods = new List<IMethod> ();

        public GetDelgateUsagesVisitor(BaseRefactoringContext ctx)
        {
            this.ctx = ctx;
        }

        public override void VisitIdentifierExpression(IdentifierExpression identifierExpression)
        {
            var mgr = ctx.Resolve (identifierExpression) as MethodGroupResolveResult;
            if (mgr != null)
                UsedMethods.AddRange (mgr.Methods);
            base.VisitIdentifierExpression(identifierExpression);
        }

        public override void VisitMemberReferenceExpression(MemberReferenceExpression memberReferenceExpression)
        {
            var mgr = ctx.Resolve (memberReferenceExpression) as MethodGroupResolveResult;
            if (mgr != null)
                UsedMethods.AddRange (mgr.Methods);
            base.VisitMemberReferenceExpression(memberReferenceExpression);
        }
    }

    class GatherVisitor : GatherVisitorBase
    {
        GetDelgateUsagesVisitor usedDelegates;
        public GatherVisitor (BaseRefactoringContext ctx, GetDelgateUsagesVisitor usedDelegates)
        : base (ctx)
        {
            this.usedDelegates = usedDelegates;
        }

        public override void VisitMethodDeclaration(MethodDeclaration methodDeclaration)
        {
            // Only some methods are candidates for the warning

            if (methodDeclaration.Body.IsNull)
                return;
            var methodResolveResult = ctx.Resolve(methodDeclaration) as MemberResolveResult;
            if (methodResolveResult == null)
                return;
            var member = methodResolveResult.Member;
            if (member.IsOverride)
                return;
            if (member.ImplementedInterfaceMembers.Any ())
                return;
            if (usedDelegates.UsedMethods.Any (m => m.Region.Begin == methodDeclaration.StartLocation))
                return;
            foreach (var parameter in methodDeclaration.Parameters)
                parameter.AcceptVisitor (this);
        }

        public override void VisitParameterDeclaration (ParameterDeclaration parameterDeclaration)
        {
            base.VisitParameterDeclaration (parameterDeclaration);

            if (!(parameterDeclaration.Parent is MethodDeclaration))
                return;

            var resolveResult = ctx.Resolve (parameterDeclaration) as LocalResolveResult;
            if (resolveResult == null)
                return;

            if (ctx.FindReferences (parameterDeclaration.Parent, resolveResult.Variable).Any(r => r.Node != parameterDeclaration))
                return;

            AddIssue (parameterDeclaration.NameToken, ctx.TranslateString ("Parameter is never used"));
        }
    }
}
}
