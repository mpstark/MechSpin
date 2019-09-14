using BattleTech;
using BattleTech.UI;
using Harmony;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace MechSpin.Patches
{
	[HarmonyPatch(typeof(MechBayPanel), "Init", typeof(SimGameState))]
    public static class MechBayPanel_Init_Patch
    {
        public static void Postfix(MechBayPanel __instance)
        {
            Main.SetupUI(__instance.GetRepresentation().transform);
        }
    }
}
