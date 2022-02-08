using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive
{
    public class FileTypeHelper
    {
        public static Dictionary<string, Type[]> _fileTypes = new();

        static FileTypeHelper()
        {
            _fileTypes.Add("acousticdata", new[] { typeof(worldAcousticDataResource) });
            _fileTypes.Add("actionanimdb", new[] { typeof(animActionAnimDatabase) });
            _fileTypes.Add("aiarch", new[] { typeof(AIArchetype) });
            _fileTypes.Add("animgraph", new[] { typeof(animAnimGraph) });
            _fileTypes.Add("anims", new[] { typeof(animAnimSet) });
            _fileTypes.Add("app", new[] { typeof(appearanceAppearanceResource) });
            _fileTypes.Add("archetypes", new[] { typeof(AIArchetypeSet) });
            _fileTypes.Add("areas", new[] { typeof(gameAreaResource) });
            _fileTypes.Add("audiovehcurveset", new[] { typeof(vehicleAudioVehicleCurveSet) });
            _fileTypes.Add("audio_metadata", new[] { typeof(audioCookedMetadataResource) });
            _fileTypes.Add("behavior", new[] { typeof(AIbehaviorResource) });
            _fileTypes.Add("bikecurveset", new[] { typeof(vehicleBikeCurveSet) });
            _fileTypes.Add("camcurveset", new[] { typeof(gameCameraCurveSet) });
            _fileTypes.Add("cfoliage", new[] { typeof(worldFoliageCompiledResource) });
            _fileTypes.Add("charcustpreset", new[] { typeof(gameuiCharacterCustomizationUiPreset), typeof(gameuiCharacterCustomizationPreset) }); // gameuiCharacterCustomizationPreset is "guessed", could be other extension
            _fileTypes.Add("cminimap", new[] { typeof(minimapEncodedShapes) });
            _fileTypes.Add("community", new[] { typeof(communityCommunityTemplate) });
            _fileTypes.Add("conversations", new[] { typeof(scnInterestingConversationsResource) });
            _fileTypes.Add("cookedanims", new[] { typeof(animAnimSetupResource) });
            _fileTypes.Add("cookedapp", new[] { typeof(appearanceCookedAppearanceData) });
            _fileTypes.Add("cookedprefab", new[] { typeof(worldCookedPrefabData) }); // is "guessed", could be other extension
            _fileTypes.Add("cooked_mlsetup", new[] { typeof(CookedMultilayer_Setup) });
            _fileTypes.Add("credits", new[] { typeof(inkCreditsResource) });
            _fileTypes.Add("csv", new[] { typeof(C2dArray) });
            _fileTypes.Add("cubemap", new[] { typeof(CCubeTexture) });
            _fileTypes.Add("curveresset", new[] { typeof(CurveResourceSet) });
            _fileTypes.Add("curveset", new[] { typeof(CurveSet) });
            _fileTypes.Add("devices", new[] { typeof(gameDeviceResource) });
            _fileTypes.Add("dtex", new[] { typeof(DynamicTexture) });
            _fileTypes.Add("effect", new[] { typeof(worldEffect) });
            _fileTypes.Add("ent", new[] { typeof(entEntityTemplate) });
            _fileTypes.Add("env", new[] { typeof(worldEnvironmentDefinition) });
            _fileTypes.Add("envparam", new[] { typeof(worldEnvironmentAreaParameters) });
            _fileTypes.Add("envprobe", new[] { typeof(CReflectionProbeDataResource) });
            _fileTypes.Add("es", new[] { typeof(gameEffectSet) });
            _fileTypes.Add("facialcustom", new[] { typeof(animFacialCustomizationSet) });
            _fileTypes.Add("facialsetup", new[] { typeof(animFacialSetup) });
            _fileTypes.Add("fb2tl", new[] { typeof(worldAutoFoliageMapping) });
            _fileTypes.Add("fnt", new[] { typeof(rendFont) });
            _fileTypes.Add("folbrush", new[] { typeof(worldFoliageBrush) });
            _fileTypes.Add("foldest", new[] { typeof(worldFoliageDestructionResource) });
            _fileTypes.Add("fp", new[] { typeof(CFoliageProfile) });
            _fileTypes.Add("game", new[] { typeof(gsmGameDefinition) });
            _fileTypes.Add("gamedef", new[] { typeof(gsmGameDefinition) });
            _fileTypes.Add("garmentlayerparams", new[] { typeof(garmentGarmentLayerParams) });
            _fileTypes.Add("genericanimdb", new[] { typeof(animGenericAnimDatabase) });
            _fileTypes.Add("geometry_cache", new[] { typeof(physicsGeometryCache) });
            _fileTypes.Add("gidata", new[] { typeof(CGIDataResource) });
            _fileTypes.Add("gradient", new[] { typeof(CGradient) });
            _fileTypes.Add("hitrepresentation", new[] { typeof(gameHitRepresentationResource) });
            _fileTypes.Add("hp", new[] { typeof(CHairProfile) });
            _fileTypes.Add("ies", new[] { typeof(CIESDataResource) });
            _fileTypes.Add("inkanim", new[] { typeof(inkanimAnimationLibraryResource) });
            _fileTypes.Add("inkatlas", new[] { typeof(inkTextureAtlas) });
            _fileTypes.Add("inkcharcustomization", new[] { typeof(gameuiCharacterCustomizationInfoResource) });
            _fileTypes.Add("inkfontfamily", new[] { typeof(inkFontFamilyResource) });
            _fileTypes.Add("inkfullscreencomposition", new[] { typeof(inkFullscreenCompositionResource) });
            _fileTypes.Add("inkgamesettings", new[] { typeof(inkGameSettingsResource) });
            _fileTypes.Add("inkhud", new[] { typeof(inkHudEntriesResource) });
            _fileTypes.Add("inklayers", new[] { typeof(inkLayersResource) });
            _fileTypes.Add("inkmenu", new[] { typeof(inkMenuResource) });
            _fileTypes.Add("inkshapecollection", new[] { typeof(inkShapeCollectionResource) });
            _fileTypes.Add("inkstyle", new[] { typeof(inkStyleResource) });
            _fileTypes.Add("inktypography", new[] { typeof(inkTypographyResource) });
            _fileTypes.Add("inkwidget", new[] { typeof(inkWidgetLibraryResource) });
            _fileTypes.Add("interaction", new[] { typeof(gameinteractionsInteractionDescriptorResource) });
            _fileTypes.Add("journal", new[] { typeof(gameJournalResource) });
            _fileTypes.Add("journaldesc", new[] { typeof(gameJournalDescriptorResource) });
            _fileTypes.Add("json", new[] { typeof(JsonResource) });
            _fileTypes.Add("lane_connections", new[] { typeof(worldTrafficPersistentLaneConnectionsResource) });
            _fileTypes.Add("lane_polygons", new[] { typeof(worldTrafficPersistentLanePolygonResource) });
            _fileTypes.Add("lane_spots", new[] { typeof(worldTrafficLanesSpotsResource) });
            _fileTypes.Add("lights", new[] { typeof(CDistantLightsResource) });
            _fileTypes.Add("lipmap", new[] { typeof(animLipsyncMapping) });
            _fileTypes.Add("location", new[] { typeof(gameLocationResource) });
            _fileTypes.Add("locopaths", new[] { typeof(navLocomotionPathResource) });
            _fileTypes.Add("loot", new[] { typeof(gameLootResource) });
            _fileTypes.Add("mappins", new[] { typeof(gameMappinResource) });
            _fileTypes.Add("matlib", new[] { typeof(CMaterialLayerLibrary) });
            _fileTypes.Add("mesh", new[] { typeof(CMesh) });
            _fileTypes.Add("mi", new[] { typeof(CMaterialInstance) });
            _fileTypes.Add("mlmask", new[] { typeof(Multilayer_Mask) });
            _fileTypes.Add("mlsetup", new[] { typeof(Multilayer_Setup) });
            _fileTypes.Add("mltemplate", new[] { typeof(Multilayer_LayerTemplate) });
            _fileTypes.Add("morphtarget", new[] { typeof(MorphTargetMesh) });
            _fileTypes.Add("mt", new[] { typeof(CMaterialTemplate) });
            _fileTypes.Add("null_areas", new[] { typeof(worldTrafficNullAreaCollisionResource) });
            _fileTypes.Add("particle", new[] { typeof(CParticleSystem) });
            _fileTypes.Add("phys", new[] { typeof(physicsSystemResource) });
            _fileTypes.Add("physicalscene", new[] { typeof(CPhysicsDecorationResource) });
            _fileTypes.Add("physmatlib", new[] { typeof(physicsMaterialLibraryResource) });
            _fileTypes.Add("poimappins", new[] { typeof(gamePointOfInterestMappinResource) });
            _fileTypes.Add("psrep", new[] { typeof(gamePersistentStateDataResource) });
            _fileTypes.Add("quest", new[] { typeof(questQuestResource) });
            _fileTypes.Add("questphase", new[] { typeof(questQuestPhaseResource) });
            _fileTypes.Add("regionset", new[] { typeof(CTextureRegionSet) });
            _fileTypes.Add("remt", new[] { typeof(CMaterialTemplate) });
            _fileTypes.Add("reps", new[] { typeof(CParticleSystem) });
            _fileTypes.Add("reslist", new[] { typeof(redResourceListResource), typeof(worldWorldListResource) });
            _fileTypes.Add("rig", new[] { typeof(animRig) });
            _fileTypes.Add("scene", new[] { typeof(scnSceneResource) });
            _fileTypes.Add("scenerid", new[] { typeof(scnRidResource) });
            _fileTypes.Add("scenesversions", new[] { typeof(scnScenesVersions) });
            _fileTypes.Add("smartobject", new[] { typeof(gameSmartObjectResource) });
            _fileTypes.Add("smartobjects", new[] { typeof(gameSmartObjectsCompiledResource) });
            _fileTypes.Add("sp", new[] { typeof(CSkinProfile) });
            _fileTypes.Add("spatial_representation", new[] { typeof(worldTrafficPersistentSpatialResource) });
            _fileTypes.Add("streamingsector", new[] { typeof(worldStreamingSector) });
            _fileTypes.Add("streamingsector_inplace", new[] { typeof(worldStreamingSectorInplaceContent) });
            _fileTypes.Add("streamingworld", new[] { typeof(worldStreamingWorld) });
            _fileTypes.Add("terrainsetup", new[] { typeof(CTerrainSetup) });
            _fileTypes.Add("texarray", new[] { typeof(CTextureArray) });
            _fileTypes.Add("traffic_collisions", new[] { typeof(worldTrafficCollisionResource) });
            _fileTypes.Add("traffic_persistent", new[] { typeof(worldTrafficPersistentResource) });
            _fileTypes.Add("vehcommoncurveset", new[] { typeof(gameVehicleCommonCurveSet) });
            _fileTypes.Add("vehcurveset", new[] { typeof(gameVehicleCurveSet) });
            _fileTypes.Add("voicetags", new[] { typeof(locVoiceTagListResource) });
            _fileTypes.Add("w2mesh", new[] { typeof(CMesh) });
            _fileTypes.Add("w2mi", new[] { typeof(CMaterialInstance) });
            _fileTypes.Add("workspot", new[] { typeof(workWorkspotResource) });
            _fileTypes.Add("xbm", new[] { typeof(CBitmapTexture) });
            _fileTypes.Add("xcube", new[] { typeof(CCubeTexture) });
        }

        public static string[] GetFileExtensions(string filePath)
        {
            using var fs = File.OpenRead(filePath);
            using var cr2wReader = new CR2WReader(fs);

            if (cr2wReader.ReadFileInfo(out var info) != EFileReadErrorCodes.NoError)
            {
                return Array.Empty<string>();
            }

            var extensions = new List<string>();
            foreach (var kvp in _fileTypes)
            {
                if (kvp.Value.Any(x => x.Name == info.StringDict[1]))
                {
                    extensions.Add(kvp.Key);
                }
            }

            return extensions.ToArray();
        }

        public static string[] GetFileExtensions(CR2WFile file)
        {
            var extensions = new List<string>();
            foreach (var kvp in _fileTypes)
            {
                if (kvp.Value.Contains(file.RootChunk.GetType()))
                {
                    extensions.Add(kvp.Key);
                }
            }

            return extensions.ToArray();
        }

        public static Type[] GetRootNodeType(string fileType) => _fileTypes[fileType];
    }
}
