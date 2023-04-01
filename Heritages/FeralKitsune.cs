using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Selection;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Selection;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Conditions.Builder;
using BlueprintCore.Conditions.Builder.ContextEx;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using GarbageAdditions.Utilities;

namespace GarbageAdditions.Heritages
{
    class FeralKitsune
    {
        private static readonly string KitsuneFeralName = "KitsuneHeritageFeral";
        private static readonly string KitsuneFeralDisplayName = "Kitsune.Heritage.Feral.DisplayName";
        private static readonly string KitsuneFeralDescription = "Kitsune.Heritage.Feral.Description";

        public static void Configure()
        {
            _ = FeatureConfigurator.New(KitsuneFeralName, Guids.KitsuneHeritageFeral)
                .CopyFrom(FeatureRefs.KitsuneHeritageClassic)
                .SetDisplayName(KitsuneFeralDisplayName)
                .SetDescription(KitsuneFeralDescription)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Strength, value: 2)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Constitution, value: 2)
                .AddStatBonus(ModifierDescriptor.Racial, stat: StatType.Intelligence, value: -2)
                .Configure();
        }
    }
}
