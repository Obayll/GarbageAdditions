using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;

namespace GarbageAdditions.Utilities
{
    class Blueprints
    {
        #region Kitsune
        public static BlueprintFeatureSelectionReference KitsuneHeritageSelectionRef => Extensions.GetBlueprintReference<BlueprintFeatureSelectionReference>("ec40cc350b18c8c47a59b782feb91d1f");

        public static BlueprintFeatureReference ChangeShapeKitsuneRef => Extensions.GetBlueprintReference<BlueprintFeatureReference>("88063b0ec1cbc8b499e313cde36a8519");

        public static BlueprintFeatureReference AgileKitsuneRef => Extensions.GetBlueprintReference<BlueprintFeatureReference>("32944d9af38d25342ad32dc1f407c714"); 

        public static BlueprintFeatureReference KitsuneMagicRef => Extensions.GetBlueprintReference<BlueprintFeatureReference>("0b71c1a7941bfa4429e281245371efc6");

        public static BlueprintFeatureReference KeenSensesRef => Extensions.GetBlueprintReference<BlueprintFeatureReference>("9c747d24f6321f744aa1bb4bd343880d");
        #endregion

        #region Background Selections
        public static BlueprintFeatureSelectionReference BackgroundWarriorSelectionRef => Extensions.GetBlueprintReference<BlueprintFeatureSelectionReference>("291f372e27b29f149ad15ff219fe15d9");
        #endregion

        #region Classes
        public static BlueprintCharacterClass FighterClass => Extensions.GetBlueprint<BlueprintCharacterClass>("48ac8db94d5de7645906c7d0ad3bcfbd");

        public static BlueprintCharacterClassReference FighterClassRef => Extensions.GetBlueprintReference<BlueprintCharacterClassReference>("48ac8db94d5de7645906c7d0ad3bcfbd");
        #endregion

        #region Archetypes
        public static BlueprintArchetypeReference TwoHandedFighterArchetypeRef => Extensions.GetBlueprintReference<BlueprintArchetypeReference>("84643e02a764bff4a9c1aba333a53c89");
        #endregion
    }
}
