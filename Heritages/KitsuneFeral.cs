using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GarbageAdditions.Utilities;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;

namespace GarbageAdditions.Heritages
{
    class KitsuneFeral
    {
        private static readonly string FeralName = "KitsuneHeritageFeral";
        private static readonly string FeralDisplayName = "Kitsune.Heritage.Feral.DisplayName";
        private static readonly string FeralDescription = "Kitsune.Heritage.Feral.Description";

        public static void Configure()
        {
            _ = FeatureConfigurator.New(FeralName, Guids.HeritageKitsuneFeral)
                .CopyFrom(FeatureRefs.KitsuneHeritageClassic)
                .SetDisplayName(FeralDisplayName)
                .SetDescription(FeralDescription)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Strength, value: 2)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Constitution, value: 2)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Intelligence, value: -2)
                .Configure();
        }
    }
}
