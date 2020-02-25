using System;
using System.Reflection;
using Verse;
using HarmonyLib;

namespace NoXpDrain
{
    partial class NoXpDrain : Mod
    {
        public NoXpDrain(ModContentPack content) : base(content)
        {
            Log.Message($"{typeof(NoXpDrain).Assembly.GetName().Name} :: {typeof(NoXpDrain).Assembly.GetName().Version} - Starting Harmony Patch...");
            try
            {
                // swapped to Harmony2 patch definitions
                // HarmonyInstance instance = HarmonyInstance.Create("com.extendedstorage.patches");
                var instance = new Harmony("com.extendexstorage.patches");
                instance.PatchAll(Assembly.GetExecutingAssembly());
                Log.Message($"{typeof(NoXpDrain).Assembly.GetName().Name} :: {typeof(NoXpDrain).Assembly.GetName().Version} - Harmony patches applied.");
            }
            catch (Exception ex)
            {
                Log.Error($"{typeof(NoXpDrain).Assembly.GetName().Name} :: {typeof(NoXpDrain).Assembly.GetName().Version} - Error Found when Patching");
                Log.Error($"{typeof(NoXpDrain).Assembly.GetName().Name} :: Caught exception: " + ex);
            }
            Log.Message($"{typeof(NoXpDrain).Assembly.GetName().Name} :: {typeof(NoXpDrain).Assembly.GetName().Version} - No further Patches detected...");
        }
    }
}
