using System.Collections.Generic;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Types;
using Kingmaker.Enums;
using Kingmaker.Blueprints;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Blueprints.Items.Armors;
using GarbageAdditions.Utilities;

namespace GarbageAdditions.Backgrounds
{
    class ExoticWarrior
    {
        private static readonly string ExoticWarriorName = "BackgroundExoticWarrior";
        private static readonly string ExoticWarriorDisplayName = "Background.ExoticWarrior.DisplayName";
        private static readonly string ExoticWarriorDescription = "Background.ExoticWarrior.Description";

        public static void Configure()
        {
            var facts = new List<Blueprint<BlueprintUnitFactReference>>
            {
                FeatureRefs.LightArmorProficiency.ToString(),
                FeatureRefs.ElvenCurvedBladeProficiency.ToString()
            };

            _ = FeatureConfigurator.New(ExoticWarriorName, Guids.BackgroundExoticWarrior)
                .SetDisplayName(ExoticWarriorDisplayName)
                .SetDescription(ExoticWarriorDescription)
                .AddFacts(facts)
                .AddClassSkill(StatType.SkillAthletics)
                .AddClassSkill(StatType.SkillMobility)
                .AddBackgroundClassSkill(StatType.SkillAthletics)
                .AddBackgroundClassSkill(StatType.SkillMobility)
                .AddBackgroundArmorProficiency(ArmorProficiencyGroup.Light, stackBonus: ContextValues.Constant(1))
                .AddBackgroundWeaponProficiency(WeaponCategory.ElvenCurvedBlade, stackBonusType: ModifierDescriptor.Trait, stackBonus: ContextValues.Constant(1))
                .AddToFeatureSelection(Blueprints.BackgroundWarriorSelectionRef)
                .Configure();
        }
    }
}
