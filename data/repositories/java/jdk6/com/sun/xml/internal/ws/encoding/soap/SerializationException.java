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

package com.sun.xml.internal.ws.encoding.soap;
import com.sun.xml.internal.ws.util.exception.JAXWSExceptionBase;
import com.sun.xml.internal.ws.util.localization.Localizable;

/**
 * SerializationException represents an exception that occurred while
 * serializing a Java value as XML.
 *
 * @see JAXWSExceptionBase
 *
 * @author WS Development Team
 */
public class SerializationException extends JAXWSExceptionBase
{

    public SerializationException(String key, Object... args)
    {
        super(key, args);
    }

    public SerializationException(Localizable arg)
    {
        super("nestedSerializationError", arg);
    }

    public SerializationException(Throwable throwable)
    {
        super(throwable);
    }

    public String getDefaultResourceBundleName()
    {
        return "com.sun.xml.internal.ws.resources.encoding";
    }

}