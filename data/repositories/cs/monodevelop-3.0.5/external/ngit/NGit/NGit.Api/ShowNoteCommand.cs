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

using System.IO;
using NGit;
using NGit.Api;
using NGit.Api.Errors;
using NGit.Notes;
using NGit.Revwalk;
using Sharpen;

namespace NGit.Api
{
/// <summary>Show an object note.</summary>
/// <remarks>Show an object note.</remarks>
/// <seealso><a href="http://www.kernel.org/pub/software/scm/git/docs/git-notes.html"
/// *      >Git documentation about Notes</a></seealso>
public class ShowNoteCommand : GitCommand<Note>
{
    private RevObject id;

    private string notesRef = Constants.R_NOTES_COMMITS;

    /// <param name="repo"></param>
    protected internal ShowNoteCommand(Repository repo) : base(repo)
    {
    }

    /// <exception cref="NGit.Api.Errors.GitAPIException"></exception>
    public override Note Call()
    {
        CheckCallable();
        RevWalk walk = new RevWalk(repo);
        NoteMap map = NoteMap.NewEmptyMap();
        RevCommit notesCommit = null;
        try
        {
            Ref @ref = repo.GetRef(notesRef);
            // if we have a notes ref, use it
            if (@ref != null)
            {
                notesCommit = walk.ParseCommit(@ref.GetObjectId());
                map = NoteMap.Read(walk.GetObjectReader(), notesCommit);
            }
            return map.GetNote(id);
        }
        catch (IOException e)
        {
            throw new JGitInternalException(e.Message, e);
        }
        finally
        {
            walk.Release();
        }
    }

    /// <summary>Sets the object id of object you want a note on</summary>
    /// <param name="id"></param>
    /// <returns>
    ///
    /// <code>this</code>
    /// </returns>
    public virtual NGit.Api.ShowNoteCommand SetObjectId(RevObject id)
    {
        CheckCallable();
        this.id = id;
        return this;
    }

    /// <param name="notesRef">
    /// the ref to read notes from. Note, the default value of
    /// <see cref="NGit.Constants.R_NOTES_COMMITS">NGit.Constants.R_NOTES_COMMITS</see>
    /// will be used if nothing is
    /// set
    /// </param>
    /// <returns>
    ///
    /// <code>this</code>
    /// </returns>
    /// <seealso cref="NGit.Constants.R_NOTES_COMMITS">NGit.Constants.R_NOTES_COMMITS</seealso>
    public virtual NGit.Api.ShowNoteCommand SetNotesRef(string notesRef)
    {
        CheckCallable();
        this.notesRef = notesRef;
        return this;
    }
}
}
