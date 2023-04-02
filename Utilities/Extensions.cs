using System;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Selection;

namespace GarbageAdditions.Utilities
{
    static class Extensions
    {
        // https://github.com/Vek17/TabletopTweaks-Core/blob/master/TabletopTweaks-Core/Utilities/CollectionExtentions.cs
        public static T[] AppendToArray<T>(this T[] array, T value)
        {
            var len = array?.Length ?? 0;
            var result = new T[len + 1];
            if (len > 0)
            {
                Array.Copy(array, result, len);
            }
            result[len] = value;
            return result;
        }

        // https://github.com/JohN100x1/WOTR_IsekaiMod/blob/master/IsekaiMod/Utilities/ExtensionMethods.cs
        public static void AddToSelection(this BlueprintFeatureSelection selection, BlueprintFeature feature)
        {
            selection.m_AllFeatures = selection.m_AllFeatures.AppendToArray(feature.ToReference<BlueprintFeatureReference>());
        }

        // https://github.com/Vek17/TabletopTweaks-Core/blob/master/TabletopTweaks-Core/Utilities/BlueprintTools.cs
        public static T GetBlueprintReference<T>(string id) where T : BlueprintReferenceBase
        {
            var assetId = BlueprintGuid.Parse(id);
            return GetBlueprintReference<T>(assetId);
        }
        public static T GetBlueprintReference<T>(BlueprintGuid id) where T : BlueprintReferenceBase
        {
            var reference = Activator.CreateInstance<T>();
            reference.deserializedGuid = id;
            return reference;
        }
        public static T GetBlueprint<T>(string id) where T : SimpleBlueprint
        {
            var assetId = BlueprintGuid.Parse(id);
            return GetBlueprint<T>(assetId);
        }
        public static T GetBlueprint<T>(BlueprintGuid id) where T : SimpleBlueprint
        {
            SimpleBlueprint asset = ResourcesLibrary.TryGetBlueprint(id);
            T value = asset as T;
            return value;
        }
    }
}
