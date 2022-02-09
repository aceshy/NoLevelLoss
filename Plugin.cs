using BepInEx;
using HarmonyLib;

namespace NoLevelLoss
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [HarmonyPatch]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony(PluginInfo.PLUGIN_GUID).PatchAll();
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Skills), "OnDeath")]
        static bool Skills_OnDeath()
        {
            return false;
        }
    }
}
