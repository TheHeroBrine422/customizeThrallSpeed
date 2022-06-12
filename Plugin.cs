using BepInEx;
using BepInEx.IL2CPP;
using Wetstone.API;

namespace customizeThrallSpeed
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("xyz.molenzwiebel.wetstone")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            if (VWorld.IsServer)
            {
                Log.LogInfo("I am on the server!");
            }

            if (VWorld.IsClient)
            {
                Log.LogInfo("I am on the client!");
            }
        }
    }
}
