﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketIO.Core;

namespace SocketIOClient.IntegrationTests
{
    [TestClass]
    public class V2NspWebSocketTests : WebSocketBaseTests
    {
        protected override string ServerUrl => Common.Startup.V2_NSP_WS;
        protected override string ServerTokenUrl => Common.Startup.V2_NSP_WS_TOKEN;
        protected override EngineIO EIO => EngineIO.V3;
    }
}