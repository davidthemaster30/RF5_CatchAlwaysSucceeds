using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using BepInEx.IL2CPP;
using BepInEx.Logging;

namespace RF5_TamingAlwaysSucceeds
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess(GAME_PROCESS)]
    public class Main : BasePlugin
    {
        #region PluginInfo
        private const string GUID = "6F30B61A-C42C-8F75-613E-C9860D6862F8";
        private const string NAME = "RF5_CatchSuccess";
        private const string VERSION = "1.0";
        private const string GAME_PROCESS = "Rune Factory 5.exe";
        #endregion

        public static new ManualLogSource Log;
        private Harmony harmony = new Harmony(GUID);

        public override void Load()
        {
            Log = base.Log;
            harmony.PatchAll();
        }
    }
}
