/*
 * Copyright (c) 2005, 2006, Oracle and/or its affiliates. All rights reserved.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * This code is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License version 2 only, as
 * published by the Free Software Foundation.  Oracle designates this
 * particular file as subject to the "Classpath" exception as provided
 * by Oracle in the LICENSE file that accompanied this code.
 *
 * This code is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
 * version 2 for more details (a copy is included in the LICENSE file that
 * accompanied this code).
 *
 * You should have received a copy of the GNU General Public License version
 * 2 along with this work; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 * Please contact Oracle, 500 Oracle Parkway, Redwood Shores, CA 94065 USA
 * or visit www.oracle.com if you need additional information or have any
 * questions.
 */
package com.sun.xml.internal.rngom.binary;

import com.sun.xml.internal.rngom.binary.visitor.PatternFunction;
import com.sun.xml.internal.rngom.binary.visitor.PatternVisitor;
import org.xml.sax.Locator;
import org.xml.sax.SAXException;

public class ListPattern extends Pattern
{
    Pattern p;
    Locator locator;

    ListPattern(Pattern p, Locator locator)
    {
        super(false,
              DATA_CONTENT_TYPE,
              combineHashCode(LIST_HASH_CODE, p.hashCode()));
        this.p = p;
        this.locator = locator;
    }

    Pattern expand(SchemaPatternBuilder b)
    {
        Pattern ep = p.expand(b);
        if (ep != p)
            return b.makeList(ep, locator);
        else
            return this;
    }

    void checkRecursion(int depth) throws SAXException
    {
        p.checkRecursion(depth);
    }

    boolean samePattern(Pattern other)
    {
        return (other instanceof ListPattern
                && p == ((ListPattern)other).p);
    }

    public void accept(PatternVisitor visitor)
    {
        visitor.visitList(p);
    }

    public Object apply(PatternFunction f)
    {
        return f.caseList(this);
    }

    void checkRestrictions(int context, DuplicateAttributeDetector dad, Alphabet alpha)
    throws RestrictionViolationException
    {
        switch (context)
        {
        case DATA_EXCEPT_CONTEXT:
            throw new RestrictionViolationException("data_except_contains_list");
        case START_CONTEXT:
            throw new RestrictionViolationException("start_contains_list");
        case LIST_CONTEXT:
            throw new RestrictionViolationException("list_contains_list");
        }
        try
        {
            p.checkRestrictions(LIST_CONTEXT, dad, null);
        }
        catch (RestrictionViolationException e)
        {
            e.maybeSetLocator(locator);
            throw e;
        }
    }

    Pattern getOperand()
    {
        return p;
    }
}
