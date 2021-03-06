﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Aliyun.Acs.Core.Auth;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class SHA256withRSASignerTest
    {
        [Fact]
        public void GetSignerName()
        {
            var instance = new SHA256withRSASigner();
            var signer = instance.GetSignerName();
            Assert.Equal("SHA256withRSA", signer);
        }

        [Fact]
        public void GetSignerType()
        {
            var instance = new SHA256withRSASigner();
            var signerType = instance.GetSignerType();
            Assert.Equal("PRIVATEKEY", signerType);
        }

        [Fact]
        public void GetSignerVersion()
        {
            var instance = new SHA256withRSASigner();
            var signerVersion = instance.GetSignerVersion();
            Assert.Equal("1.0", signerVersion);
        }

        [Fact]
        public void SignString()
        {
            var instance = new SHA256withRSASigner();

            // Get different result each time.
            var str = instance.SignString("foo", "secret");
            Assert.NotEmpty(str);

            var mock = new Mock<AlibabaCloudCredentials>();
            mock.Setup(foo => foo.GetAccessKeySecret()).Returns("secret");
            var credentials = mock.Object;
            var str2 = instance.SignString("foo", credentials);
            Assert.NotEmpty(str2);
        }
    }
}
