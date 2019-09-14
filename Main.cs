using System.Reflection;
using Harmony;
using HBS.Logging;
using UnityEngine;
using Logger = HBS.Logging.Logger;

namespace MechSpin
{
    public static class Main
    {
        internal static ILog HBSLog;

        public static void Init(string modDir, string settings)
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.MechSpin");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            HBSLog = Logger.GetLogger("MechSpin");
        }

        internal static void SetupSpin(GameObject mech)
        {
            if (mech.GetComponent<SpinComponent>() != null)
                return;

            mech.AddComponent<SpinComponent>();
        }
    }
}
