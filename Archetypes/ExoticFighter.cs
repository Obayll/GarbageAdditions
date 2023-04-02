using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GarbageAdditions.Utilities;

namespace GarbageAdditions.Archetypes
{
    class ExoticFighter
    {
        private static readonly string ExoticFighterName = "ExoticFighterArchetype";
        private static readonly string ExoticFighterDisplayName = "Archetype.ExoticFighter.DisplayName";
        private static readonly string ExoticFighterDescription = "Archetype.ExoticFighter.Description";

        public static void Configure()
        {
            var exoticFighter = ArchetypeConfigurator.New(ExoticFighterName, Guids.ExoticFighterArchetype)
                .CopyFrom(Blueprints.TwoHandedFighterArchetypeRef)
                .SetLocalizedName(ExoticFighterDisplayName)
                .SetLocalizedDescription(ExoticFighterDescription)
                .Configure();

            _ = CharacterClassConfigurator.For(Blueprints.FighterClassRef).AddToArchetypes(exoticFighter).Configure();
        }
    }
}
