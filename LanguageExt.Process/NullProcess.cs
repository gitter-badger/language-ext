﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    public class NullProcess : IProcess
    {
        public Map<string, ProcessId> Children
        {
            get
            {
                return Map.empty<string,ProcessId>();
            }
        }

        public ProcessId Id
        {
            get
            {
                return ProcessId.None;
            }
        }

        public ProcessName Name
        {
            get
            {
                return "$";
            }
        }

        public ProcessId Parent
        {
            get
            {
                return ProcessId.None;
            }
        }

        public void Dispose()
        {
        }

        public Unit Restart()
        {
            return Unit.Default;
        }

        public Unit Startup()
        {
            return Unit.Default;
        }

        public Unit Shutdown()
        {
            return Unit.Default;
        }

        public Unit LinkChild(ProcessId pid)
        {
            return Unit.Default;
        }

        public Unit UnlinkChild(ProcessId pid)
        {
            return Unit.Default;
        }

        public object GetState()
        {
            return null;
        }

        /// <summary>
        /// Publish to the PublishStream
        /// </summary>
        public Unit Publish(object message)
        {
            return Unit.Default;
        }

        public IObservable<object> PublishStream => null;

        public IObservable<object> StateStream => null;

    }
}
