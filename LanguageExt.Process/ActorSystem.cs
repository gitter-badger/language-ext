﻿using System;
using static LanguageExt.Process;

namespace LanguageExt
{
    internal static class ActorSystem
    {
        public static ActorSystemState Inbox(ActorSystemState state, object msg)
        {
            try
            {
                if (msg is ActorSystemMessage)
                {
                    logInfo(msg);

                    var rmsg = msg as ActorSystemMessage;
                    switch (rmsg.Tag)
                    {
                        case ActorSystemMessageTag.Startup:
                            state = state.Startup();
                            break;

                        case ActorSystemMessageTag.AddToStore: 
                            state = AddToStore(state, rmsg as AddToStoreMessage);
                            break;

                        case ActorSystemMessageTag.RemoveFromStore:
                            state = RemoveFromStore(state, rmsg as RemoveFromStoreMessage);
                            break;

                        case ActorSystemMessageTag.Tell:
                        case ActorSystemMessageTag.TellSystem:
                        case ActorSystemMessageTag.TellUserControl:
                            Tell(state, rmsg as TellMessage);
                            break;

                        case ActorSystemMessageTag.ShutdownProcess:
                            ShutdownProcess(state, rmsg as ShutdownProcessMessage);
                            break;

                        case ActorSystemMessageTag.ShutdownAll:
                            ShutdownAll(state);
                            break;

                        case ActorSystemMessageTag.GetChildren:
                            GetChildren(state, rmsg as GetChildrenMessage);
                            break;

                        case ActorSystemMessageTag.Publish:
                            Publish(state, rmsg as PubMessage);
                            break;

                        case ActorSystemMessageTag.Reply:
                            Reply(state, rmsg as ReplyMessage);
                            break;

                        case ActorSystemMessageTag.ObservePub:
                            ObservePub(state, rmsg as ObservePubMessage);
                            break;

                        case ActorSystemMessageTag.ObserveState:
                            ObserveState(state, rmsg as ObserveStateMessage);
                            break;
                    }
                }
                else if (msg is SystemMessage)
                {
                    state.TellSystem(msg as SystemMessage, state.Root);
                }
                else if (msg is UserControlMessage)
                {
                    state.TellUserControl(msg as UserControlMessage, state.Root);
                }
                else
                {
                    publish(msg);
                }
            }

            catch (Exception e)
            {
                logSysErr(e);
            }
            return state;
        }

        private static void Reply(ActorSystemState state, ReplyMessage msg) =>
            state.Reply(msg.ReplyTo, msg.Message, msg.Sender, msg.RequestId);

        private static Unit GetChildren(ActorSystemState state, GetChildrenMessage msg) =>
            state.GetChildren(msg.ProcessId);

        private static ActorSystemState ShutdownProcess(ActorSystemState state, ShutdownProcessMessage msg) =>
            state = state.ShutdownProcess(msg.ProcessId);

        private static Unit ObservePub(ActorSystemState state, ObservePubMessage msg) =>
            state.ObservePub(msg.ProcessId, msg.MsgType);

        private static Unit ObserveState(ActorSystemState state, ObserveStateMessage msg) =>
            state.ObserveState(msg.ProcessId);

        private static Unit Publish(ActorSystemState state, PubMessage msg) =>
            state.Publish(msg.ProcessId, msg.Message);

        private static ActorSystemState AddToStore(ActorSystemState state, AddToStoreMessage msg) =>
            state.AddOrUpdateStoreAndStartup(msg.Process, msg.Inbox, msg.Flags);

        private static ActorSystemState RemoveFromStore(ActorSystemState state, RemoveFromStoreMessage msg) =>
            state.RemoveFromStore(msg.ProcessId);

        private static ActorSystemState Tell(ActorSystemState state, TellMessage msg)
        {
            state.Tell(msg.ProcessId, msg.Sender, msg.Tag, msg.Message);
            return state;
        }

        private static Unit ShutdownAll(ActorSystemState state) =>
            state.Shutdown();
    }
}
