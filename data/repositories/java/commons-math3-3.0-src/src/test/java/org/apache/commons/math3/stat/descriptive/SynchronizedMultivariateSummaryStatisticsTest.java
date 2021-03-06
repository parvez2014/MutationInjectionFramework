/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements. See the NOTICE file distributed with this
 * work for additional information regarding copyright ownership. The ASF
 * licenses this file to You under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0 Unless required by applicable law
 * or agreed to in writing, software distributed under the License is
 * distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 */
package org.apache.commons.math3.stat.descriptive;


/**
 * Test cases for the {@link SynchronizedMultivariateSummaryStatisticsTest} class.
 * @version $Id: SynchronizedMultivariateSummaryStatisticsTest.java 1244107 2012-02-14 16:17:55Z erans $
 *          2007) $
 */
public final class SynchronizedMultivariateSummaryStatisticsTest
    extends MultivariateSummaryStatisticsTest
{
    @Override
    protected MultivariateSummaryStatistics createMultivariateSummaryStatistics(int k, boolean isCovarianceBiasCorrected)
    {
        return new SynchronizedMultivariateSummaryStatistics(k, isCovarianceBiasCorrected);
    }
}
