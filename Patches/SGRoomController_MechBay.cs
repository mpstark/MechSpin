using BattleTech;
using Harmony;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace MechSpin.Patches
{
	[HarmonyPatch(typeof(MechRepresentationSimGame), "Init")]
    public static class MechRepresentationSimGame_Init_Patch
    {
        public static void Postfix(MechRepresentationSimGame __instance)
        {
    		Main.SetupSpin(__instance.gameObject);
        }
    }
}
