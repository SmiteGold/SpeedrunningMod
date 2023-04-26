using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using PatchQuest;
using ModdingUtilities;

namespace SpeedrunningMod
{
    public class ModMain : PatchQuestMod
    {
        //called every frame while on a quest
        public override void MainUpdate()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Reset();
            }
        }



        public void Reset()
        {
            LoggerInstance.Msg("Resetting...");
            Game.LeaveCurrentArea(Direction.NONE);
            SceneManager.ExitToTitle();
        }
    }
}
