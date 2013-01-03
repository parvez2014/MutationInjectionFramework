//
// System.Configuration.LongValidatorAttribute.cs
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//

#if NET_2_0
using System;

namespace System.Configuration
{

[AttributeUsage (AttributeTargets.Property)]
public sealed class LongValidatorAttribute : ConfigurationValidatorAttribute
{
    bool excludeRange = false;
    long maxValue = 0;
    long minValue = 0;
    ConfigurationValidatorBase instance;

    public LongValidatorAttribute ()
    {
    }

    public bool ExcludeRange
    {
        get
        {
            return excludeRange;
        }
        set
        {
            excludeRange = value;
            instance = null;
        }
    }

    public long MaxValue
    {
        get
        {
            return maxValue;
        }
        set
        {
            maxValue = value;
            instance = null;
        }
    }

    public long MinValue
    {
        get
        {
            return minValue;
        }
        set
        {
            minValue = value;
            instance = null;
        }
    }

    public override ConfigurationValidatorBase ValidatorInstance
    {
        get
        {
            if (instance == null)
                instance = new LongValidator (minValue, maxValue, excludeRange);

            return instance;
        }
    }
}
}

#endif