﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSandbox.GameServer.NewGameObjects;

namespace LeagueSandbox.GameServer.Events.Args
{
    public class Obj_AI_BaseBuffUpdateEventArgs : EventArgs
    {
        public BuffInstance Buff { get; private set; }

        public Obj_AI_BaseBuffUpdateEventArgs(BuffInstance buff)
        {
            Buff = buff;
        }
    }
}