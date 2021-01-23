using MelonLoader;
using Harmony;

namespace NoRespawn
{
    public class NoRespawnMod : MelonMod
    {
        private HarmonyInstance harmony;

        public override void OnApplicationStart()
        {
            harmony = HarmonyInstance.Create("tj.horner.norespawn");
            harmony?.PatchAll();

            MelonLogger.Log($"Patched: {harmony?.GetPatchedMethods().Join() ?? "none"}");
        }
    }
}
