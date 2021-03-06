﻿using System;
using LanguageExt;
using static LanguageExt.Prelude;

namespace LanguageExt
{
    class NullInbox : IActorInbox
    {
        public Unit Shutdown() => unit;
        public Unit Startup(IProcess pid, ProcessId supervisor, Option<ICluster> cluster) => unit;
        public Unit Tell(object message, ProcessId sender) => unit;
        public Unit TellSystem(SystemMessage message) => unit;
        public Unit TellUserControl(UserControlMessage message) => unit;

        public void Dispose()
        {
        }
    }
}
