using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

namespace InfectionPortraitSwapMod;

[ModInitializer(nameof(Initialize))]
public partial class MainFile : Node
{
    private const string ModId = "InfectionPortraitSwapMod"; //Used for logger and harmony names.

    public static MegaCrit.Sts2.Core.Logging.Logger Logger { get; } = new(ModId, MegaCrit.Sts2.Core.Logging.LogType.Generic);

    public static void Initialize()
    {
        Harmony harmony = new(ModId);

        harmony.PatchAll();
    }
}
