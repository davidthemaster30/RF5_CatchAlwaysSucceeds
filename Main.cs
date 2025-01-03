using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using RF5_CatchAlwaysSucceeds;

namespace RF5_TamingAlwaysSucceeds;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess(GAME_PROCESS)]
public class Main : BasePlugin
{
    public static new ManualLogSource Log;
    private const string GAME_PROCESS = "Rune Factory 5.exe";
    private Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

    public override void Load()
    {
        Log = base.Log;
        harmony.PatchAll();
    }
}
