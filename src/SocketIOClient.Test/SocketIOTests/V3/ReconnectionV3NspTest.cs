﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SocketIOClient.Test.SocketIOTests.V3
{
    [TestClass]
    public class ReconnectionV3NspTest : ReconnectionTest
    {
        public ReconnectionV3NspTest()
        {
            SocketIOCreator = new SocketIOV3NspCreator();
        }

        protected override ISocketIOCreateable SocketIOCreator { get; }

        // NOTE: This test case is wrong, because the client will not automatically reconnect after the server closes the connection.
        //[TestMethod]
        //public override async Task ReconnectionTrueTest()
        //{
        //    await base.ReconnectionTrueTest();
        //}

        [TestMethod]
        public override async Task ReconnectionFalseTest()
        {
            await base.ReconnectionFalseTest();
        }

        // NOTE: This test case is wrong, because the client will not automatically reconnect after the server closes the connection.
        //[TestMethod]
        //public override async Task ReconnectingTest()
        //{
        //    await base.ReconnectingTest();
        //}

        // NOTE: This test case is wrong, because the client will not automatically reconnect after the server closes the connection.
        //[TestMethod]
        //public override async Task ReconnectionAttemptsExceededTest()
        //{
        //    await base.ReconnectionAttemptsExceededTest();
        //}

        [TestMethod]
        public override async Task ManuallyReconnectionTest()
        {
            await base.ManuallyReconnectionTest();
        }
    }
}
