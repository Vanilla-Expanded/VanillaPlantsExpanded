using HarmonyLib;

using System.Reflection;
using Verse;



namespace VanillaPlantsExpanded
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.vanillaplantsexpanded");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }


    }
}