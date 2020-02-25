using RimWorld;
using Verse;
using HarmonyLib;
using System.Reflection;

namespace NoXpDrain
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var instance = new Harmony("rimworld.tad.exp");
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(SkillRecord))]
        [HarmonyPatch("Interval")]
        static class SkillRecord_Interval_Patch
        {
            static bool Prefix() => false;
        }
    }
}
