/*
This code is derived from jgit (http://eclipse.org/jgit).
Copyright owners are documented in jgit's IP log.

This program and the accompanying materials are made available
under the terms of the Eclipse Distribution License v1.0 which
accompanies this distribution, is reproduced below, and is
available at http://www.eclipse.org/org/documents/edl-v10.php

All rights reserved.

Redistribution and use in source and binary forms, with or
without modification, are permitted provided that the following
conditions are met:

- Redistributions of source code must retain the above copyright
  notice, this list of conditions and the following disclaimer.

- Redistributions in binary form must reproduce the above
  copyright notice, this list of conditions and the following
  disclaimer in the documentation and/or other materials provided
  with the distribution.

- Neither the name of the Eclipse Foundation, Inc. nor the
  names of its contributors may be used to endorse or promote
  products derived from this software without specific prior
  written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND
CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES,
INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using NGit.Internal;
using NGit.Revwalk;
using NGit.Revwalk.Filter;
using Sharpen;

namespace NGit.Revwalk.Filter
{
/// <summary>Filter that includes commits after a configured number are skipped.</summary>
/// <remarks>Filter that includes commits after a configured number are skipped.</remarks>
public class SkipRevFilter : RevFilter
{
    private readonly int skip;

    private int count;

    /// <summary>Create a new skip filter.</summary>
    /// <remarks>Create a new skip filter.</remarks>
    /// <param name="skip">the number of commits to skip</param>
    /// <returns>a new filter</returns>
    public static RevFilter Create(int skip)
    {
        if (skip < 0)
        {
            throw new ArgumentException(JGitText.Get().skipMustBeNonNegative);
        }
        return new NGit.Revwalk.Filter.SkipRevFilter(skip);
    }

    private SkipRevFilter(int skip)
    {
        this.skip = skip;
    }

    /// <exception cref="NGit.Errors.StopWalkException"></exception>
    /// <exception cref="NGit.Errors.MissingObjectException"></exception>
    /// <exception cref="NGit.Errors.IncorrectObjectTypeException"></exception>
    /// <exception cref="System.IO.IOException"></exception>
    public override bool Include(RevWalk walker, RevCommit cmit)
    {
        if (skip > count++)
        {
            return false;
        }
        return true;
    }

    public override RevFilter Clone()
    {
        return new NGit.Revwalk.Filter.SkipRevFilter(skip);
    }
}
}
