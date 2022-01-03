using System;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;
using System.Collections.Generic;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.CR2W
{
    public static class CommonFunctions
    {
        public static string[] GetResourceClassesFromExtension(ERedExtension extension)
        {
            try
            {
                return s_extensionsToClass[extension].Split(',');
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public static ERedExtension[] GetExtensionFromResourceClass(string resourceClass)
        {
            try
            {
                return s_classToExtensions[resourceClass].Split(',').Select(x => Enum.Parse<ERedExtension>(x)).ToArray();
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        private static readonly Dictionary<ERedExtension, string> s_extensionsToClass = new()
        {
            { ERedExtension.json, "JsonResource" },
            { ERedExtension.voicetags, "locVoiceTagListResource" },
            { ERedExtension.scene, "scnSceneResource" },
            { ERedExtension.audio_metadata, "audioCookedMetadataResource" },
            { ERedExtension.xbm, "CBitmapTexture" },
            { ERedExtension.app, "appearanceAppearanceResource" },
            { ERedExtension.curveset, "CurveSet" },
            { ERedExtension.behavior, "AIbehaviorResource" },
            { ERedExtension.anims, "animAnimSet" },
            { ERedExtension.w2mesh, "CMesh" },
            { ERedExtension.particle, "CParticleSystem" },
            { ERedExtension.mesh, "CMesh" },
            { ERedExtension.csv, "C2dArray" },
            { ERedExtension.hp, "CHairProfile" },
            { ERedExtension.fp, "CFoliageProfile" },
            { ERedExtension.sp, "CSkinProfile" },
            { ERedExtension.inkfontfamily, "inkFontFamilyResource" },
            { ERedExtension.es, "gameEffectSet" },
            { ERedExtension.mltemplate, "Multilayer_LayerTemplate" },
            { ERedExtension.aiarch, "AIArchetype" },
            { ERedExtension.charcustpreset, "gameuiCharacterCustomizationUiPreset" },
            { ERedExtension.garmentlayerparams, "garmentGarmentLayerParams" },
            { ERedExtension.effect, "worldEffect" },
            { ERedExtension.fnt, "rendFont" },
            { ERedExtension.rig, "animRig" },
            { ERedExtension.ent, "entEntityTemplate" },
            { ERedExtension.env, "worldEnvironmentDefinition" },
            { ERedExtension.dtex, "DynamicTexture" },
            { ERedExtension.inkcharcustomization, "gameuiCharacterCustomizationInfoResource" },
            { ERedExtension.w2mi, "CMaterialInstance" },
            { ERedExtension.inkshapecollection, "inkShapeCollectionResource" },
            { ERedExtension.inkfullscreencomposition, "inkFullscreenCompositionResource" },
            { ERedExtension.mlmask, "Multilayer_Mask" },
            { ERedExtension.actionanimdb, "animActionAnimDatabase" },
            { ERedExtension.inkanim, "inkanimAnimationLibraryResource" },
            { ERedExtension.bk2, "" },
            { ERedExtension.inkatlas, "inkTextureAtlas" },
            { ERedExtension.inktypography, "inkTypographyResource" },
            { ERedExtension.archetypes, "AIArchetypeSet" },
            { ERedExtension.texarray, "CTextureArray" },
            { ERedExtension.inkgamesettings, "inkGameSettingsResource" },
            { ERedExtension.envparam, "worldEnvironmentAreaParameters" },
            { ERedExtension.facialsetup, "animFacialSetup" },
            { ERedExtension.xcube, "CCubeTexture" },
            { ERedExtension.inkwidget, "inkWidgetLibraryResource" },
            { ERedExtension.curveresset, "CurveResourceSet" },
            { ERedExtension.mlsetup, "Multilayer_Setup" },
            { ERedExtension.gradient, "CGradient" },
            { ERedExtension.regionset, "CTextureRegionSet" },
            { ERedExtension.interaction, "gameinteractionsInteractionDescriptorResource" },
            { ERedExtension.acousticdata, "worldAcousticDataResource" },
            { ERedExtension.envprobe, "CReflectionProbeDataResource" },
            { ERedExtension.smartobjects, "gameSmartObjectsCompiledResource" },
            { ERedExtension.null_areas, "worldTrafficNullAreaCollisionResource" },
            { ERedExtension.psrep, "gamePersistentStateDataResource" },
            { ERedExtension.streamingsector, "worldStreamingSector" },
            { ERedExtension.spatial_representation, "worldTrafficPersistentSpatialResource" },
            { ERedExtension.areas, "gameAreaResource" },
            { ERedExtension.location, "gameLocationResource" },
            { ERedExtension.lane_connections, "worldTrafficPersistentLaneConnectionsResource" },
            { ERedExtension.streamingworld, "worldStreamingWorld" },
            { ERedExtension.lane_polygons, "worldTrafficPersistentLanePolygonResource" },
            { ERedExtension.devices, "gameDeviceResource" },
            { ERedExtension.locopaths, "navLocomotionPathResource" },
            { ERedExtension.loot, "gameLootResource" },
            { ERedExtension.geometry_cache, "physicsGeometryCache" },
            { ERedExtension.traffic_persistent, "worldTrafficPersistentResource" },
            { ERedExtension.poimappins, "gamePointOfInterestMappinResource" },
            { ERedExtension.lane_spots, "worldTrafficLanesSpotsResource" },
            { ERedExtension.mappins, "gameMappinResource" },
            { ERedExtension.mi, "CMaterialInstance" },
            { ERedExtension.streamingsector_inplace, "worldStreamingSectorInplaceContent" },
            { ERedExtension.cfoliage, "worldFoliageCompiledResource" },
            { ERedExtension.folbrush, "worldFoliageBrush" },
            { ERedExtension.conversations, "scnInterestingConversationsResource" },
            { ERedExtension.physicalscene, "CPhysicsDecorationResource" },
            { ERedExtension.smartobject, "gameSmartObjectResource" },
            { ERedExtension.animgraph, "animAnimGraph" },
            { ERedExtension.cminimap, "minimapEncodedShapes" },
            { ERedExtension.cubemap, "CCubeTexture" },
            { ERedExtension.lights, "CDistantLightsResource" },
            { ERedExtension.terrainsetup, "CTerrainSetup" },
            { ERedExtension.genericanimdb, "animGenericAnimDatabase" },
            { ERedExtension.inkhud, "inkHudEntriesResource" },
            { ERedExtension.fb2tl, "worldAutoFoliageMapping" },
            { ERedExtension.traffic_collisions, "worldTrafficCollisionResource" },
            { ERedExtension.gidata, "CGIDataResource" },
            { ERedExtension.cookedanims, "animAnimSetupResource" },
            { ERedExtension.cookedapp, "appearanceCookedAppearanceData" },
            { ERedExtension.workspot, "workWorkspotResource" },
            { ERedExtension.phys, "physicsSystemResource" },
            { ERedExtension.morphtarget, "MorphTargetMesh" },
            { ERedExtension.camcurveset, "gameCameraCurveSet" },
            { ERedExtension.facialcustom, "animFacialCustomizationSet" },
            { ERedExtension.hitrepresentation, "gameHitRepresentationResource" },
            { ERedExtension.community, "communityCommunityTemplate" },
            { ERedExtension.scenerid, "scnRidResource" },
            { ERedExtension.questphase, "questQuestPhaseResource" },
            { ERedExtension.gamedef, "gsmGameDefinition" },
            { ERedExtension.quest, "questQuestResource" },
            { ERedExtension.inkstyle, "inkStyleResource" },
            { ERedExtension.audiovehcurveset, "vehicleAudioVehicleCurveSet" },
            { ERedExtension.journaldesc, "gameJournalDescriptorResource" },
            { ERedExtension.cooked_mlsetup, "CookedMultilayer_Setup" },
            { ERedExtension.vehcurveset, "gameVehicleCurveSet" },
            { ERedExtension.reslist, "redResourceListResource,worldWorldListResource" },
            { ERedExtension.matlib, "CMaterialLayerLibrary" },
            { ERedExtension.reps, "CParticleSystem" },
            { ERedExtension.credits, "inkCreditsResource" },
            { ERedExtension.inklayers, "inkLayersResource" },
            { ERedExtension.inkmenu, "inkMenuResource" },
            { ERedExtension.scenesversions, "scnScenesVersions" },
            { ERedExtension.foldest, "worldFoliageDestructionResource" },
            { ERedExtension.physmatlib, "physicsMaterialLibraryResource" },
            { ERedExtension.bikecurveset, "vehicleBikeCurveSet" },
            { ERedExtension.vehcommoncurveset, "gameVehicleCommonCurveSet" },
            { ERedExtension.game, "gsmGameDefinition" },
            { ERedExtension.journal, "gameJournalResource" },
            { ERedExtension.lipmap, "animLipsyncMapping" },
            { ERedExtension.mt, "CMaterialTemplate" },
            { ERedExtension.ies, "CIESDataResource" },
            { ERedExtension.remt, "CMaterialTemplate" },

        };

        private static readonly Dictionary<string, string> s_classToExtensions = new()
        {
            { "JsonResource", "json" },
            { "locVoiceTagListResource", "voicetags" },
            { "scnSceneResource", "scene" },
            { "audioCookedMetadataResource", "audio_metadata" },
            { "CBitmapTexture", "xbm" },
            { "appearanceAppearanceResource", "app" },
            { "CurveSet", "curveset" },
            { "AIbehaviorResource", "behavior" },
            { "animAnimSet", "anims" },
            { "CMesh", "w2mesh,mesh" },
            { "CParticleSystem", "particle,reps" },
            { "C2dArray", "csv" },
            { "CHairProfile", "hp" },
            { "CFoliageProfile", "fp" },
            { "CSkinProfile", "sp" },
            { "inkFontFamilyResource", "inkfontfamily" },
            { "gameEffectSet", "es" },
            { "Multilayer_LayerTemplate", "mltemplate" },
            { "AIArchetype", "aiarch" },
            { "gameuiCharacterCustomizationUiPreset", "charcustpreset" },
            { "garmentGarmentLayerParams", "garmentlayerparams" },
            { "worldEffect", "effect" },
            { "rendFont", "fnt" },
            { "animRig", "rig" },
            { "entEntityTemplate", "ent" },
            { "worldEnvironmentDefinition", "env" },
            { "DynamicTexture", "dtex" },
            { "gameuiCharacterCustomizationInfoResource", "inkcharcustomization" },
            { "CMaterialInstance", "w2mi,mi" },
            { "inkShapeCollectionResource", "inkshapecollection" },
            { "inkFullscreenCompositionResource", "inkfullscreencomposition" },
            { "Multilayer_Mask", "mlmask" },
            { "animActionAnimDatabase", "actionanimdb" },
            { "inkanimAnimationLibraryResource", "inkanim" },
            { "inkTextureAtlas", "inkatlas" },
            { "inkTypographyResource", "inktypography" },
            { "AIArchetypeSet", "archetypes" },
            { "CTextureArray", "texarray" },
            { "inkGameSettingsResource", "inkgamesettings" },
            { "worldEnvironmentAreaParameters", "envparam" },
            { "animFacialSetup", "facialsetup" },
            { "CCubeTexture", "xcube,cubemap" },
            { "inkWidgetLibraryResource", "inkwidget" },
            { "CurveResourceSet", "curveresset" },
            { "Multilayer_Setup", "mlsetup" },
            { "CGradient", "gradient" },
            { "CTextureRegionSet", "regionset" },
            { "gameinteractionsInteractionDescriptorResource", "interaction" },
            { "worldAcousticDataResource", "acousticdata" },
            { "CReflectionProbeDataResource", "envprobe" },
            { "gameSmartObjectsCompiledResource", "smartobjects" },
            { "worldTrafficNullAreaCollisionResource", "null_areas" },
            { "gamePersistentStateDataResource", "psrep" },
            { "worldStreamingSector", "streamingsector" },
            { "worldTrafficPersistentSpatialResource", "spatial_representation" },
            { "gameAreaResource", "areas" },
            { "gameLocationResource", "location" },
            { "worldTrafficPersistentLaneConnectionsResource", "lane_connections" },
            { "worldStreamingWorld", "streamingworld" },
            { "worldTrafficPersistentLanePolygonResource", "lane_polygons" },
            { "gameDeviceResource", "devices" },
            { "navLocomotionPathResource", "locopaths" },
            { "gameLootResource", "loot" },
            { "physicsGeometryCache", "geometry_cache" },
            { "worldTrafficPersistentResource", "traffic_persistent" },
            { "gamePointOfInterestMappinResource", "poimappins" },
            { "worldTrafficLanesSpotsResource", "lane_spots" },
            { "gameMappinResource", "mappins" },
            { "worldStreamingSectorInplaceContent", "streamingsector_inplace" },
            { "worldFoliageCompiledResource", "cfoliage" },
            { "worldFoliageBrush", "folbrush" },
            { "scnInterestingConversationsResource", "conversations" },
            { "CPhysicsDecorationResource", "physicalscene" },
            { "gameSmartObjectResource", "smartobject" },
            { "animAnimGraph", "animgraph" },
            { "minimapEncodedShapes", "cminimap" },
            { "CDistantLightsResource", "lights" },
            { "CTerrainSetup", "terrainsetup" },
            { "animGenericAnimDatabase", "genericanimdb" },
            { "inkHudEntriesResource", "inkhud" },
            { "worldAutoFoliageMapping", "fb2tl" },
            { "worldTrafficCollisionResource", "traffic_collisions" },
            { "CGIDataResource", "gidata" },
            { "animAnimSetupResource", "cookedanims" },
            { "appearanceCookedAppearanceData", "cookedapp" },
            { "workWorkspotResource", "workspot" },
            { "physicsSystemResource", "phys" },
            { "MorphTargetMesh", "morphtarget" },
            { "gameCameraCurveSet", "camcurveset" },
            { "animFacialCustomizationSet", "facialcustom" },
            { "gameHitRepresentationResource", "hitrepresentation" },
            { "communityCommunityTemplate", "community" },
            { "scnRidResource", "scenerid" },
            { "questQuestPhaseResource", "questphase" },
            { "gsmGameDefinition", "gamedef,game" },
            { "questQuestResource", "quest" },
            { "inkStyleResource", "inkstyle" },
            { "vehicleAudioVehicleCurveSet", "audiovehcurveset" },
            { "gameJournalDescriptorResource", "journaldesc" },
            { "CookedMultilayer_Setup", "cooked_mlsetup" },
            { "gameVehicleCurveSet", "vehcurveset" },
            { "redResourceListResource,worldWorldListResource", "reslist" },
            { "CMaterialLayerLibrary", "matlib" },
            { "inkCreditsResource", "credits" },
            { "inkLayersResource", "inklayers" },
            { "inkMenuResource", "inkmenu" },
            { "scnScenesVersions", "scenesversions" },
            { "worldFoliageDestructionResource", "foldest" },
            { "physicsMaterialLibraryResource", "physmatlib" },
            { "vehicleBikeCurveSet", "bikecurveset" },
            { "gameVehicleCommonCurveSet", "vehcommoncurveset" },
            { "gameJournalResource", "journal" },
            { "animLipsyncMapping", "lipmap" },
            { "CMaterialTemplate", "mt,remt" },
            { "CIESDataResource", "ies" },

        };
        

        #region Methods

        /// <summary>
        ///  Gets the DXGI format for CP77 dds buffers from a given ETextureCompression and ETextureRawFormat
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="rawFormat"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static DXGI_FORMAT GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat, ILoggerService logger)
        {
            switch (compression)
            {
                case ETextureCompression.TCM_QualityR:
                    return DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM;

                case ETextureCompression.TCM_QualityRG:
                case ETextureCompression.TCM_Normalmap:
                    return DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM;

                case ETextureCompression.TCM_QualityColor:
                    return DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM;

                case ETextureCompression.TCM_DXTNoAlpha:
                case ETextureCompression.TCM_Normals_DEPRECATED:
                    return DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM;

                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_DXTAlpha:
                case ETextureCompression.TCM_NormalsHigh_DEPRECATED:
                    return DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM;

                case ETextureCompression.TCM_None:
                {
                    switch (rawFormat)
                    {
                        case ETextureRawFormat.TRF_Invalid:
                        case ETextureRawFormat.TRF_TrueColor:
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;

                        case ETextureRawFormat.TRF_DeepColor:
                            return DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM;

                        case ETextureRawFormat.TRF_HDRFloat:
                            return DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT;

                        case ETextureRawFormat.TRF_HDRHalf:
                            return DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT;

                        case ETextureRawFormat.TRF_HDRFloatGrayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT;

                        case ETextureRawFormat.TRF_R8G8:
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM;

                        case ETextureRawFormat.TRF_Grayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_R8_UINT;

                        case ETextureRawFormat.TRF_AlphaGrayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_A8_UNORM;

                        case ETextureRawFormat.TRF_Grayscale_Font:
                            //throw new NotImplementedException($"{nameof(GetDXGIFormat)}: TRF_Grayscale_Font");
                        case ETextureRawFormat.TRF_R32UI:
                            //return DXGI_FORMAT.R32_UINT;
                            //throw new NotImplementedException($"{nameof(GetDXGIFormat)}: TRF_R32UI");
                            logger.Warning($"Unknown texture format: {rawFormat.ToString()}");
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(rawFormat), rawFormat, null);
                    }
                }

                case ETextureCompression.TCM_RGBE:
                case ETextureCompression.TCM_Normals:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_NormalsGloss_DEPRECATED:
                case ETextureCompression.TCM_NormalsGloss:
                case ETextureCompression.TCM_TileMap:
                case ETextureCompression.TCM_HalfHDR_Unsigned:
                case ETextureCompression.TCM_HalfHDR:
                case ETextureCompression.TCM_HalfHDR_Signed:
                case ETextureCompression.TCM_Max:
                {
                    logger.Warning($"Unknown texture compression format: {compression.ToString()}");
                    return DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(compression), compression, null);
            }
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        /// <param name="DXGIFormat"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static (ETextureCompression, ETextureRawFormat) GetRedFormatsFromDxgiFormat(DXGI_FORMAT DXGIFormat)
        {
            switch (DXGIFormat)
            {
                case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloat);

                case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRHalf);

                case DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_DeepColor);

                case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                    throw new NotImplementedException($"{nameof(GetRedFormatsFromDxgiFormat)}: R8G8B8A8_UNORM");
                case DXGI_FORMAT.DXGI_FORMAT_R32_UINT:
                    throw new NotImplementedException($"{nameof(GetRedFormatsFromDxgiFormat)}: R32_UINT");
                case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_R8G8);

                case DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloatGrayscale);

                case DXGI_FORMAT.DXGI_FORMAT_R8_UINT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_Grayscale);

                case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_AlphaGrayscale);

                case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
                    return (ETextureCompression.TCM_DXTNoAlpha, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM:
                    throw new NotImplementedException($"{nameof(GetRedFormatsFromDxgiFormat)}: BC2_UNORM");
                case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
                    return (ETextureCompression.TCM_DXTAlpha, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
                    return (ETextureCompression.TCM_QualityColor, ETextureRawFormat.TRF_Invalid);

                default:
                    throw new ArgumentOutOfRangeException(nameof(DXGIFormat), DXGIFormat, null);
            }
        }

        public static (ETextureCompression, ETextureRawFormat)
            GetRedFormatsFromTextureGroup(GpuWrapApieTextureGroup textureGroup)
        {
            switch (textureGroup)
            {
                case GpuWrapApieTextureGroup.TEXG_Generic_Grayscale:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid);

                case GpuWrapApieTextureGroup.TEXG_Generic_Normal: //TODO: support TCM_Normals_DEPRECATED?
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid);

                case GpuWrapApieTextureGroup.TEXG_Generic_Color:
                case GpuWrapApieTextureGroup.TEXG_Generic_Data:
                case GpuWrapApieTextureGroup.TEXG_Generic_UI:
                case GpuWrapApieTextureGroup.TEXG_Generic_Font:
                case GpuWrapApieTextureGroup.TEXG_Generic_LUT:
                case GpuWrapApieTextureGroup.TEXG_Generic_MorphBlend:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Color:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Normal:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Grayscale:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Microblend:
                default:
                    throw new ArgumentOutOfRangeException(nameof(textureGroup), textureGroup, null);
            }
        }




        #endregion Methods
    }
}
