﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using PatchQuest;

namespace SpeedrunningMod
{
    public class ModMain : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                base.LoggerInstance.Msg("Resetting...");
                Game.LeaveCurrentArea(Direction.NONE);
                SceneManager.ExitToTitle();
            }
        }
    }
}