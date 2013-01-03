/*
 * $Header: /home/cvs/jakarta-commons/primitives/src/test/org/apache/commons/collections/primitives/adapters/TestListShortList.java,v 1.1 2003/10/13 22:46:54 scolebourne Exp $
 * ====================================================================
 * The Apache Software License, Version 1.1
 *
 * Copyright (c) 2003 The Apache Software Foundation.  All rights
 * reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in
 *    the documentation and/or other materials provided with the
 *    distribution.
 *
 * 3. The end-user documentation included with the redistribution, if
 *    any, must include the following acknowledgement:
 *       "This product includes software developed by the
 *        Apache Software Foundation (http://www.apache.org/)."
 *    Alternately, this acknowledgement may appear in the software itself,
 *    if and wherever such third-party acknowledgements normally appear.
 *
 * 4. The names "The Jakarta Project", "Commons", and "Apache Software
 *    Foundation" must not be used to endorse or promote products derived
 *    from this software without prior written permission. For written
 *    permission, please contact apache@apache.org.
 *
 * 5. Products derived from this software may not be called "Apache"
 *    nor may "Apache" appear in their names without prior written
 *    permission of the Apache Software Foundation.
 *
 * THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED.  IN NO EVENT SHALL THE APACHE SOFTWARE FOUNDATION OR
 * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
 * LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF
 * USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT
 * OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals on behalf of the Apache Software Foundation.  For more
 * information on the Apache Software Foundation, please see
 * <http://www.apache.org/>.
 *
 */

package org.apache.commons.collections.primitives.adapters;

import java.io.Serializable;
import java.util.AbstractList;
import java.util.ArrayList;

import junit.framework.Test;
import junit.framework.TestSuite;

import org.apache.commons.collections.BulkTest;
import org.apache.commons.collections.primitives.ShortList;
import org.apache.commons.collections.primitives.TestShortList;

/**
 * @version $Revision: 1.1 $ $Date: 2003/10/13 22:46:54 $
 * @author Rodney Waldhoff
 */
public class TestListShortList extends TestShortList
{

    // conventional
    // ------------------------------------------------------------------------

    public TestListShortList(String testName)
    {
        super(testName);
    }

    public static Test suite()
    {
        TestSuite suite = BulkTest.makeSuite(TestListShortList.class);
        return suite;
    }

    // collections testing framework
    // ------------------------------------------------------------------------

    /**
     * @see org.apache.commons.collections.primitives.TestShortList#makeEmptyShortList()
     */
    protected ShortList makeEmptyShortList()
    {
        return new ListShortList(new ArrayList());
    }

    protected String[] ignoredTests()
    {
        // sublists are not serializable
        return new String[]
               {
                   "TestListShortList.bulkTestSubList.testFullListSerialization",
                   "TestListShortList.bulkTestSubList.testEmptyListSerialization",
                   "TestListShortList.bulkTestSubList.testCanonicalEmptyCollectionExists",
                   "TestListShortList.bulkTestSubList.testCanonicalFullCollectionExists",
                   "TestListShortList.bulkTestSubList.testEmptyListCompatibility",
                   "TestListShortList.bulkTestSubList.testFullListCompatibility",
                   "TestListShortList.bulkTestSubList.testSerializeDeserializeThenCompare",
                   "TestListShortList.bulkTestSubList.testSimpleSerialization"
               };
    }

    // tests
    // ------------------------------------------------------------------------

    /** @TODO need to add serialized form to cvs */
    public void testCanonicalEmptyCollectionExists()
    {
        // XXX FIX ME XXX
        // need to add a serialized form to cvs
    }

    public void testCanonicalFullCollectionExists()
    {
        // XXX FIX ME XXX
        // need to add a serialized form to cvs
    }

    public void testEmptyListCompatibility()
    {
        // XXX FIX ME XXX
        // need to add a serialized form to cvs
    }

    public void testFullListCompatibility()
    {
        // XXX FIX ME XXX
        // need to add a serialized form to cvs
    }
    public void testWrapNull()
    {
        assertNull(ListShortList.wrap(null));
    }

    public void testWrapSerializable()
    {
        ShortList list = ListShortList.wrap(new ArrayList());
        assertNotNull(list);
        assertTrue(list instanceof Serializable);
    }

    public void testWrapNonSerializable()
    {
        ShortList list = ListShortList.wrap(new AbstractList()
        {
            public Object get(int i)
            {
                throw new IndexOutOfBoundsException();
            }
            public int size()
            {
                return 0;
            }
        });
        assertNotNull(list);
        assertTrue(!(list instanceof Serializable));
    }

}