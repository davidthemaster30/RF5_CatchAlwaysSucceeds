﻿using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using RF5_CatchAlwaysSucceeds;

namespace RF5_TamingAlwaysSucceeds;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess(GAME_PROCESS)]
public class Main : BasePlugin
{
    internal static readonly ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource("TamingAlwaysSucceeds");
    private const string GAME_PROCESS = "Rune Factory 5.exe";
    private Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

    public override void Load()
    {
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION} is loading!");

        harmony.PatchAll();

        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION} is loaded!");
    }
}
