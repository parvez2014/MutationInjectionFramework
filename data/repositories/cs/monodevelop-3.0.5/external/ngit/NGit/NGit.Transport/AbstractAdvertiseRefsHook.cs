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

using System.Collections.Generic;
using NGit;
using NGit.Revwalk;
using NGit.Transport;
using Sharpen;

namespace NGit.Transport
{
/// <summary>
/// Implementation of
/// <see cref="AdvertiseRefsHook">AdvertiseRefsHook</see>
/// that advertises the same refs for
/// upload-pack and receive-pack.
/// </summary>
/// <since>2.0</since>
public abstract class AbstractAdvertiseRefsHook : AdvertiseRefsHook
{
    /// <exception cref="NGit.Transport.ServiceMayNotContinueException"></exception>
    public override void AdvertiseRefs(UploadPack uploadPack)
    {
        uploadPack.SetAdvertisedRefs(GetAdvertisedRefs(uploadPack.GetRepository(), uploadPack
                                     .GetRevWalk()));
    }

    /// <exception cref="NGit.Transport.ServiceMayNotContinueException"></exception>
    public override void AdvertiseRefs(BaseReceivePack receivePack)
    {
        IDictionary<string, Ref> refs = GetAdvertisedRefs(receivePack.GetRepository(), receivePack
                                        .GetRevWalk());
        ICollection<ObjectId> haves = GetAdvertisedHaves(receivePack.GetRepository(), receivePack
                                      .GetRevWalk());
        receivePack.SetAdvertisedRefs(refs, haves);
    }

    /// <summary>Get the refs to advertise.</summary>
    /// <remarks>Get the refs to advertise.</remarks>
    /// <param name="repository">repository instance.</param>
    /// <param name="revWalk">open rev walk on the repository.</param>
    /// <returns>set of refs to advertise.</returns>
    /// <exception cref="ServiceMayNotContinueException">abort; the message will be sent to the user.
    /// 	</exception>
    /// <exception cref="NGit.Transport.ServiceMayNotContinueException"></exception>
    protected internal abstract IDictionary<string, Ref> GetAdvertisedRefs(Repository
            repository, RevWalk revWalk);

    /// <summary>Get the additional haves to advertise.</summary>
    /// <remarks>Get the additional haves to advertise.</remarks>
    /// <param name="repository">repository instance.</param>
    /// <param name="revWalk">open rev walk on the repository.</param>
    /// <returns>
    /// set of additional haves; see
    /// <see cref="BaseReceivePack.GetAdvertisedObjects()">BaseReceivePack.GetAdvertisedObjects()
    /// 	</see>
    /// .
    /// </returns>
    /// <exception cref="ServiceMayNotContinueException">abort; the message will be sent to the user.
    /// 	</exception>
    /// <exception cref="NGit.Transport.ServiceMayNotContinueException"></exception>
    protected internal virtual ICollection<ObjectId> GetAdvertisedHaves(Repository repository
            , RevWalk revWalk)
    {
        return null;
    }
}
}