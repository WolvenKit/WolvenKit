using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
public enum ERedExtension
{
    unknown,

    acousticdata,
    actionanimdb,
    aiarch,
    animgraph,
    anims,
    app,
    archetypes,
    areas,
    audio_metadata,
    audiovehcurveset,
    behavior,
    bikecurveset,
    bk2,
    bnk,
    camcurveset,
    ccstate,
    cfoliage,
    charcustpreset,
    chromaset,
    cminimap,
    community,
    conversations,
    cooked_mlsetup,
    cookedanims,
    cookedapp,
    cookedprefab,
    credits,
    csv,
    cubemap,
    curveresset,
    curveset,
    dat,
    devices,
    dlc_manifest,
    dtex,
    effect,
    ent,
    env,
    envparam,
    envprobe,
    es,
    facialcustom,
    facialsetup,
    fb2tl,
    fnt,
    folbrush,
    foldest,
    fp,
    game,
    gamedef,
    garmentlayerparams,
    genericanimdb,
    geometry_cache,
    gidata,
    gradient,
    hitrepresentation,
    hp,
    ies,
    inkanim,
    inkatlas,
    inkcharcustomization,
    inkenginesettings,
    inkfontfamily,
    inkfullscreencomposition,
    inkgamesettings,
    inkhud,
    inklayers,
    inkmenu,
    inkshapecollection,
    inkstyle,
    inktypography,
    inkwidget,
    interaction,
    journal,
    journaldesc,
    json,
    lane_connections,
    lane_polygons,
    lane_spots,
    lights,
    lipmap,
    location,
    locopaths,
    loot,
    mappins,
    matlib,
    mesh,
    mi,
    mlmask,
    mlsetup,
    mltemplate,
    morphtarget,
    mt,
    null_areas,
    opusinfo,
    opuspak,
    particle,
    phys,
    physicalscene,
    physmatlib,
    poimappins,
    psrep,
    quest,
    questphase,
    redphysics,
    regionset,
    remt,
    reps,
    reslist,
    rig,
    scene,
    scenerid,
    scenesversions,
    smartobject,
    smartobjects,
    sp,
    spatial_representation,
    streamingblock,
    streamingquerydata,
    streamingsector,
    streamingsector_inplace,
    streamingworld,
    terrainsetup,
    texarray,
    traffic_collisions,
    traffic_persistent,
    vehcommoncurveset,
    vehcurveset,
    voicetags,
    w2mesh,
    w2mi,
    wem,
    workspot,
    worldlist,
    xbm,
    xcube,

    wdyn
}
// ReSharper restore InconsistentNaming
// ReSharper restore IdentifierTypo

public static class ERedExtensionHelper
{
    public static ERedExtension FromString(string? path)
    {
        var extStr = Path.GetExtension(path);
        if (string.IsNullOrEmpty(extStr))
        {
            return ERedExtension.unknown;
        }

        return Enum.Parse<ERedExtension>(extStr[1..]);
    }
}

public class FileTypeHelper
{
    public static readonly List<FileType> FileTypes = new();

    static FileTypeHelper()
    {
        // unused resources:
        // bink
        // entdismembermentDebris
        // gamegraphCGraphResource
        // gamePrereqsResource
        // graphGraphResource
        // LibTreeCTreeResource
        // locVoResource
        // minimapEncodedShapes
        // resResourceSnapshot
        // TweakDBResource
        // worldHeatmapResource
        // worldTrafficCollisionDebugResource
        // XmlResource

        FileTypes.Add(new FileType(ERedExtension.acousticdata, "Acoustic Data Resource", typeof(worldAcousticDataResource)));
        FileTypes.Add(new FileType(ERedExtension.actionanimdb, "Action anim database", typeof(animActionAnimDatabase)));
        FileTypes.Add(new FileType(ERedExtension.aiarch, "AI Archetype template", typeof(AIArchetype)));
        FileTypes.Add(new FileType(ERedExtension.animgraph, "Animation graph", typeof(animAnimGraph)));
        FileTypes.Add(new FileType(ERedExtension.anims, "Animation Set", typeof(animAnimSet)));
        FileTypes.Add(new FileType(ERedExtension.app, "Appearance Resource", typeof(appearanceAppearanceResource)));
        FileTypes.Add(new FileType(ERedExtension.archetypes, "AI Archetypes Set template", typeof(AIArchetypeSet)));
        FileTypes.Add(new FileType(ERedExtension.areas, "Areas", typeof(gameAreaResource)));
        FileTypes.Add(new FileType(ERedExtension.audiovehcurveset, "Audio Vehicle Curve Set", typeof(vehicleAudioVehicleCurveSet)));
        FileTypes.Add(new FileType(ERedExtension.audio_metadata, "Cooked Audio Metadata", typeof(audioCookedMetadataResource)));
        FileTypes.Add(new FileType(ERedExtension.behavior, "AI Behavior Tree", typeof(AIbehaviorResource)));
        FileTypes.Add(new FileType(ERedExtension.bikecurveset, "Bike Curve Set", typeof(vehicleBikeCurveSet)));
        // FileTypes.Add(new FileType(ERedExtension.blockout, "World blockout", typeof(worldBlockoutResource))); // not used yet
        FileTypes.Add(new FileType(ERedExtension.camcurveset, "Camera Curve Set", typeof(gameCameraCurveSet)));
        FileTypes.Add(new FileType(ERedExtension.ccstate, "Character Customization State", typeof(gameuiCharacterCustomizationPreset)));
        FileTypes.Add(new FileType(ERedExtension.cfoliage, "Foliage Compiled Resource", typeof(worldFoliageCompiledResource)));
        FileTypes.Add(new FileType(ERedExtension.charcustpreset, "UI Character Customization Preset", typeof(gameuiCharacterCustomizationUiPreset)));
        FileTypes.Add(new FileType(ERedExtension.chromaset, "Razer Chroma Animation Set", typeof(gameRazerChromaAnimationDatabase)));
        FileTypes.Add(new FileType(ERedExtension.cminimap, "Minimap Compiled Resource", typeof(minimapEncodedShapes)));
        FileTypes.Add(new FileType(ERedExtension.community, "", typeof(communityCommunityTemplate)));
        FileTypes.Add(new FileType(ERedExtension.conversations, "Conversations Group", typeof(scnInterestingConversationsResource)));
        FileTypes.Add(new FileType(ERedExtension.cookedanims, "Cooked AnimSets", typeof(animAnimSetupResource)));
        FileTypes.Add(new FileType(ERedExtension.cookedapp, "Cooked Appearance Data", typeof(appearanceCookedAppearanceData)));
        FileTypes.Add(new FileType(ERedExtension.cookedprefab, "Cooked Prefab Data", typeof(worldCookedPrefabData)));
        FileTypes.Add(new FileType(ERedExtension.cooked_mlsetup, "Cooked Multilayer Setup", typeof(CookedMultilayer_Setup)));
        FileTypes.Add(new FileType(ERedExtension.credits, "Credits Resource", typeof(inkCreditsResource)));
        FileTypes.Add(new FileType(ERedExtension.csv, "2D Array", typeof(C2dArray)));
        FileTypes.Add(new FileType(ERedExtension.cubemap, "Cubemap", typeof(CCubeTexture))); // same as xcube
        FileTypes.Add(new FileType(ERedExtension.curveresset, "Curve Resource Set template", typeof(CurveResourceSet)));
        FileTypes.Add(new FileType(ERedExtension.curveset, "Curve Set", typeof(CurveSet)));
        FileTypes.Add(new FileType(ERedExtension.devices, "Devices", typeof(gameDeviceResource)));
        // FileTypes.Add(new FileType(ERedExtension.dlc_manifest, "DLC Manifest Resource", typeof(resDlcManifest))); // not used yet
        FileTypes.Add(new FileType(ERedExtension.dtex, "2D Dynamic Texture", typeof(DynamicTexture)));
        FileTypes.Add(new FileType(ERedExtension.effect, "", typeof(worldEffect)));
        FileTypes.Add(new FileType(ERedExtension.ent, "Entity Template", typeof(entEntityTemplate)));
        FileTypes.Add(new FileType(ERedExtension.env, "Environment Definition", typeof(worldEnvironmentDefinition)));
        FileTypes.Add(new FileType(ERedExtension.envparam, "Area Environment Parameters", typeof(worldEnvironmentAreaParameters)));
        FileTypes.Add(new FileType(ERedExtension.envprobe, "Reflection Probe Data Resource", typeof(CReflectionProbeDataResource)));
        FileTypes.Add(new FileType(ERedExtension.es, "Game effect set", typeof(gameEffectSet)));
        FileTypes.Add(new FileType(ERedExtension.facialcustom, "Facial customization set", typeof(animFacialCustomizationSet)));
        FileTypes.Add(new FileType(ERedExtension.facialsetup, "Facial setup", typeof(animFacialSetup)));
        FileTypes.Add(new FileType(ERedExtension.fb2tl, "FoliageBrush to Terrainlayer mapping", typeof(worldAutoFoliageMapping)));
        FileTypes.Add(new FileType(ERedExtension.fnt, "Font", typeof(rendFont)));
        FileTypes.Add(new FileType(ERedExtension.folbrush, "Foliage Brush", typeof(worldFoliageBrush)));
        FileTypes.Add(new FileType(ERedExtension.foldest, "Foliage destruction resource", typeof(worldFoliageDestructionResource)));
        FileTypes.Add(new FileType(ERedExtension.fp, "Foliage profile", typeof(CFoliageProfile)));
        FileTypes.Add(new FileType(ERedExtension.game, "", typeof(gsmGameDefinition)));
        FileTypes.Add(new FileType(ERedExtension.gamedef, "Game Definition", typeof(gsmGameDefinition)));
        FileTypes.Add(new FileType(ERedExtension.garmentlayerparams, "Garment parameters", typeof(garmentGarmentLayerParams)));
        FileTypes.Add(new FileType(ERedExtension.genericanimdb, "Generic anim database", typeof(animGenericAnimDatabase)));
        FileTypes.Add(new FileType(ERedExtension.geometry_cache, "A collection of all collision mesh geometry", typeof(physicsGeometryCache)));
        // FileTypes.Add(new FileType(ERedExtension.geometry_cache_artifact, "An intermediate artifact for geometry cache generator", typeof(physicsGeometryCacheArtifact))); // not used yet
        FileTypes.Add(new FileType(ERedExtension.gidata, "GI Data Resource", typeof(CGIDataResource)));
        FileTypes.Add(new FileType(ERedExtension.gradient, "Gradient resource", typeof(CGradient)));
        // FileTypes.Add(new FileType(ERedExtension.grph, "Base resource class for graphs", ));  // not used yet
        // FileTypes.Add(new FileType(ERedExtension.graph, "Base resource class for graphs", ));  // not used yet
        FileTypes.Add(new FileType(ERedExtension.hitrepresentation, "Hit Representation data", typeof(gameHitRepresentationResource)));
        FileTypes.Add(new FileType(ERedExtension.hp, "Hair profile", typeof(CHairProfile)));
        FileTypes.Add(new FileType(ERedExtension.ies, "IES Light Profile Data Resource", typeof(CIESDataResource)));
        FileTypes.Add(new FileType(ERedExtension.inkanim, "Ink animation library", typeof(inkanimAnimationLibraryResource)));
        FileTypes.Add(new FileType(ERedExtension.inkatlas, "Ink texture atlas resource", typeof(inkTextureAtlas)));
        FileTypes.Add(new FileType(ERedExtension.inkcharcustomization, "Ink Character Customization Info", typeof(gameuiCharacterCustomizationInfoResource)));
        FileTypes.Add(new FileType(ERedExtension.inkenginesettings, "Ink Engine Settings Resource", typeof(inkEngineSettingsResource)));
        FileTypes.Add(new FileType(ERedExtension.inkfontfamily, "Ink Font Family", typeof(inkFontFamilyResource)));
        FileTypes.Add(new FileType(ERedExtension.inkfullscreencomposition, "Ink Fullscreen Composition", typeof(inkFullscreenCompositionResource)));
        FileTypes.Add(new FileType(ERedExtension.inkgamesettings, "Ink Game Settings Resource", typeof(inkGameSettingsResource)));
        FileTypes.Add(new FileType(ERedExtension.inkhud, "Ink HUD resource", typeof(inkHudEntriesResource)));
        FileTypes.Add(new FileType(ERedExtension.inklayers, "Ink Layers Resource", typeof(inkLayersResource)));
        FileTypes.Add(new FileType(ERedExtension.inkmenu, "Ink Menu Resource", typeof(inkMenuResource)));
        FileTypes.Add(new FileType(ERedExtension.inkshapecollection, "Ink Shape Collection Resource", typeof(inkShapeCollectionResource)));
        FileTypes.Add(new FileType(ERedExtension.inkstyle, "Ink Style Resource", typeof(inkStyleResource)));
        FileTypes.Add(new FileType(ERedExtension.inktypography, "Ink Typography", typeof(inkTypographyResource)));
        FileTypes.Add(new FileType(ERedExtension.inkwidget, "Ink widget library", typeof(inkWidgetLibraryResource)));
        FileTypes.Add(new FileType(ERedExtension.interaction, "Game interaction descriptor", typeof(gameinteractionsInteractionDescriptorResource)));
        FileTypes.Add(new FileType(ERedExtension.journal, "Journal Entry", typeof(gameJournalResource)));
        FileTypes.Add(new FileType(ERedExtension.journaldesc, "Journal Descriptor", typeof(gameJournalDescriptorResource)));
        FileTypes.Add(new FileType(ERedExtension.json, "", typeof(JsonResource)));
        FileTypes.Add(new FileType(ERedExtension.lane_connections, "Traffic persistent lane connections data", typeof(worldTrafficPersistentLaneConnectionsResource)));
        FileTypes.Add(new FileType(ERedExtension.lane_polygons, "", typeof(worldTrafficPersistentLanePolygonResource)));
        FileTypes.Add(new FileType(ERedExtension.lane_spots, "Traffic spots in lanes", typeof(worldTrafficLanesSpotsResource)));
        FileTypes.Add(new FileType(ERedExtension.lights, "Distant Lights Resource", typeof(CDistantLightsResource)));
        FileTypes.Add(new FileType(ERedExtension.lipmap, "Lipsync Mapping", typeof(animLipsyncMapping)));
        FileTypes.Add(new FileType(ERedExtension.location, "", typeof(gameLocationResource)));
        FileTypes.Add(new FileType(ERedExtension.locopaths, "Locomotion Paths", typeof(navLocomotionPathResource)));
        FileTypes.Add(new FileType(ERedExtension.loot, "", typeof(gameLootResource)));
        FileTypes.Add(new FileType(ERedExtension.mappins, "", typeof(gameMappinResource)));
        FileTypes.Add(new FileType(ERedExtension.matlib, "Material Layer Library", typeof(CMaterialLayerLibrary)));
        FileTypes.Add(new FileType(ERedExtension.mesh, "", typeof(CMesh))); //same as w2mesh
        FileTypes.Add(new FileType(ERedExtension.mi, "Material instance", typeof(CMaterialInstance))); //same as w2mi
        FileTypes.Add(new FileType(ERedExtension.mlmask, "Multilayer Mask", typeof(Multilayer_Mask)));
        FileTypes.Add(new FileType(ERedExtension.mlsetup, "Multilayer Setup", typeof(Multilayer_Setup)));
        FileTypes.Add(new FileType(ERedExtension.mltemplate, "Multilayer Layer Template", typeof(Multilayer_LayerTemplate)));
        FileTypes.Add(new FileType(ERedExtension.morphtarget, "Morph Target Mesh Resource", typeof(MorphTargetMesh)));
        FileTypes.Add(new FileType(ERedExtension.mt, "Material template", typeof(CMaterialTemplate)));  // same as remt
        FileTypes.Add(new FileType(ERedExtension.null_areas, "Null areas collision data", typeof(worldTrafficNullAreaCollisionResource)));
        FileTypes.Add(new FileType(ERedExtension.particle, "Particle System", typeof(CParticleSystem))); // same as reps
        FileTypes.Add(new FileType(ERedExtension.phys, "Physical system", typeof(physicsSystemResource)));
        FileTypes.Add(new FileType(ERedExtension.physicalscene, "Physics decoration resource", typeof(CPhysicsDecorationResource))); // same as redphysics
        FileTypes.Add(new FileType(ERedExtension.physmatlib, "Physics material definition library", typeof(physicsMaterialLibraryResource)));
        FileTypes.Add(new FileType(ERedExtension.poimappins, "POI Mappins", typeof(gamePointOfInterestMappinResource)));
        FileTypes.Add(new FileType(ERedExtension.psrep, "Persistent State Data", typeof(gamePersistentStateDataResource)));
        FileTypes.Add(new FileType(ERedExtension.quest, "", typeof(questQuestResource)));
        FileTypes.Add(new FileType(ERedExtension.questphase, "Quest Phase", typeof(questQuestPhaseResource)));
        FileTypes.Add(new FileType(ERedExtension.redphysics, "Physics decoration resource", typeof(CPhysicsDecorationResource))); // same as physicalscene
        FileTypes.Add(new FileType(ERedExtension.regionset, "Texture Region Set", typeof(CTextureRegionSet)));
        FileTypes.Add(new FileType(ERedExtension.remt, "Material template", typeof(CMaterialTemplate))); // same as mt
        FileTypes.Add(new FileType(ERedExtension.reps, "Particle System", typeof(CParticleSystem))); // same as particle
        FileTypes.Add(new FileType(ERedExtension.reslist, "List of resource files", typeof(redResourceListResource)));
        FileTypes.Add(new FileType(ERedExtension.rig, "", typeof(animRig)));
        // FileTypes.Add(new FileType(ERedExtension.rigsd, "Rig Shared Data", typeof(animRigSharedData))); // not used yet
        // FileTypes.Add(new FileType(ERedExtension.rsvg, "", typeof(SvgResource))); // not used yet, same as svg
        FileTypes.Add(new FileType(ERedExtension.scene, "", typeof(scnSceneResource)));
        FileTypes.Add(new FileType(ERedExtension.scenerid, ".re Import Data", typeof(scnRidResource)));
        FileTypes.Add(new FileType(ERedExtension.scenesversions, "Scenes Versions", typeof(scnScenesVersions)));
        FileTypes.Add(new FileType(ERedExtension.scenesversions, "Scenes Versions", typeof(scnScenesVersions)));
        // FileTypes.Add(new FileType(ERedExtension.sector_artifact, "An artifact from sector generator, used in Geometry Cache cooking to fill sector preload data", typeof(physicsSectorCacheArtifact))); // not used yet
        FileTypes.Add(new FileType(ERedExtension.smartobjects, "Smart Objects Compiled data", typeof(gameSmartObjectsCompiledResource)));
        FileTypes.Add(new FileType(ERedExtension.sp, "Skin profile", typeof(CSkinProfile)));
        FileTypes.Add(new FileType(ERedExtension.spatial_representation, "Traffic persistent spatial data", typeof(worldTrafficPersistentSpatialResource)));
        FileTypes.Add(new FileType(ERedExtension.streamingblock, "Streaming Query Data", typeof(worldStreamingBlock)));
        FileTypes.Add(new FileType(ERedExtension.streamingquerydata, "", typeof(worldStreamingQueryDataResource)));
        FileTypes.Add(new FileType(ERedExtension.streamingsector, "Streaming Sector", typeof(worldStreamingSector)));
        FileTypes.Add(new FileType(ERedExtension.streamingsector_inplace, "Streaming Sector Inplace", typeof(worldStreamingSectorInplaceContent)));
        FileTypes.Add(new FileType(ERedExtension.streamingworld, "", typeof(worldStreamingWorld)));
        // FileTypes.Add(new FileType(ERedExtension.svg, "", typeof(SvgResource))); // not used yet, same as rsvg
        FileTypes.Add(new FileType(ERedExtension.terrainsetup, "Terrain Setup", typeof(CTerrainSetup)));
        FileTypes.Add(new FileType(ERedExtension.texarray, "Texture Array", typeof(CTextureArray)));
        // FileTypes.Add(new FileType(ERedExtension.todvis, "Time of Day Visibility Resource", typeof(TimeOfDayVisibilityResource))); // not used yet
        FileTypes.Add(new FileType(ERedExtension.traffic_collisions, "Traffic collision data", typeof(worldTrafficCollisionResource)));
        FileTypes.Add(new FileType(ERedExtension.traffic_persistent, "Traffic persistent data", typeof(worldTrafficPersistentResource)));
        FileTypes.Add(new FileType(ERedExtension.vehcommoncurveset, "Vehicle Common Curve Set", typeof(gameVehicleCommonCurveSet)));
        FileTypes.Add(new FileType(ERedExtension.vehcurveset, "Vehicle Curve Set", typeof(gameVehicleCurveSet)));
        FileTypes.Add(new FileType(ERedExtension.voicetags, "Voice Tags", typeof(locVoiceTagListResource)));
        FileTypes.Add(new FileType(ERedExtension.w2mesh, "", typeof(CMesh))); //same as mesh
        FileTypes.Add(new FileType(ERedExtension.w2mi, "Material instance", typeof(CMaterialInstance))); //same as mi
        FileTypes.Add(new FileType(ERedExtension.workspot, "Work spot", typeof(workWorkspotResource)));
        FileTypes.Add(new FileType(ERedExtension.worldlist, "List of World IDs", typeof(worldWorldListResource)));
        FileTypes.Add(new FileType(ERedExtension.xbm, "Bitmap Texture", typeof(CBitmapTexture)));
        FileTypes.Add(new FileType(ERedExtension.xcube, "Cubemap", typeof(CCubeTexture))); //same as cubemap

        FileTypes.Add(new FileType(ERedExtension.wdyn, "WolvenKit Test File", typeof(DynamicResource)));
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
        foreach (var fileType in FileTypes)
        {
            if (fileType.RootType.Name == info!.StringDict[1])
            {
                extensions.Add(fileType.Extension.ToString());
            }
        }
        return extensions.ToArray();
    }

    public static string[] GetFileExtensionsFromRootName(string rootClsName)
    {
        var extensions = new List<string>();
        foreach (var fileType in FileTypes)
        {
            if (fileType.RootType.Name == rootClsName)
            {
                extensions.Add(fileType.Extension.ToString());
            }
        }
        return extensions.ToArray();
    }

    public static string[] GetFileExtensions(CR2WFile file)
    {
        var extensions = new List<string>();
        foreach (var fileType in FileTypes)
        {
            if (fileType.RootType == file.RootChunk.GetType())
            {
                extensions.Add(fileType.Extension.ToString());
            }
        }
        return extensions.ToArray();
    }

    public static string[] GetFileExtensions(RedBaseClass resource)
    {
        var extensions = new List<string>();
        foreach (var fileType in FileTypes)
        {
            if (fileType.RootType == resource.GetType())
            {
                extensions.Add(fileType.Extension.ToString());
            }
        }
        return extensions.ToArray();
    }

    public static Type? GetRootNodeType(string ext)
    {
        if (Enum.TryParse<ERedExtension>(ext, true, out var fileType))
        {
            foreach (var f in FileTypes)
            {
                if (f.Extension == fileType)
                {
                    return f.RootType;
                }
            }
        }

        return null;
    }

    public static bool IsCR2WFile(string ext)
    {
        if (ext.StartsWith('.'))
        {
            ext = ext[1..];
        }

        if (!Enum.TryParse<ERedExtension>(ext, true, out var redExtension))
        {
            return false;
        }

        return FileTypes.FirstOrDefault(x => x.Extension == redExtension) != null;
    }
}