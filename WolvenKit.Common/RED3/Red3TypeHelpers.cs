using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.RED3.CR2W
{
    public static class Red3TypeHelpers
    {
        public static string GetREDExtensionFromCVariable(CResource cvar)
        {
            //if (cvar is CResource) return "";
            if (cvar is CCookedExplorations)
                return "redexp";
            if (cvar is CBehaviorGraph)
                return "w2beh";

            if (cvar is CCharacterEntityTemplate)
                return "w2cent";
            if (cvar is CEntityTemplate)
                return "w2ent";

            if (cvar is CFoliageResource)
                return "flyr";
            if (cvar is CGameWorld)
                return "w2w";
            if (cvar is CMaterialGraph)
                return "w2mg";
            if (cvar is CMaterialInstance)
                return "w2mi";

            if (cvar is CPhysicsDestructionResource)
                return "reddest"; // check before mesh
            if (cvar is CMesh)
                return "w2mesh";

            if (cvar is CRagdoll)
                return "w2ragdoll";

            if (cvar is CCutsceneTemplate)
                return "w2cutscene";     // check before CSkeletalAnimationSet
            if (cvar is CStorySceneDialogset)
                return "w2dset";      // check before CSkeletalAnimationSet
            if (cvar is CSkeletalAnimationSet)
                return "w2anims";

            if (cvar is CExtAnimEventsFile)
                return "w2animev";

            if (cvar is CSwarmCellMap)
                return "cellmap";
            if (cvar is CSwfResource)
                return "redswf";

            //if (cvar is CUmbraScene) return "";           //??

            if (cvar is CWayPointsCollectionsSet)
                return "redwpset";
            if (cvar is CUmbraTile)
                return "w3occlusion";
            if (cvar is CFont)
                return "w2fnt";
            if (cvar is CTextureArray)
                return "texarray";
            if (cvar is CTerrainTile)
                return "w2ter";

            //if (cvar is CSwfTexture) return "redswf";     //??
            if (cvar is CBitmapTexture)
                return "xbm";

            if (cvar is CCubeTexture)
                return "w2cube";
            if (cvar is CGenericGrassMask)
                return "grassmask";
            if (cvar is CParticleSystem)
                return "w2p";

            if (cvar is CDyngResource)
                return "w3dyng";
            if (cvar is CSkeleton)
                return "w3fac"; // w3dyng // w3fac

            if (cvar is CWayPointsCollection)
                return "redwpset";
            //if (cvar is C2dArray) return ""; // unused
            if (cvar is CApexClothResource)
                return "redcloth";
            if (cvar is CApexDestructionResource)
                return "redapex";
            // if (cvar is CApexResource) return "";   // unused
            if (cvar is CAreaMapPinsResource)
                return "w2am";
            if (cvar is CBehTree)
                return "w2behtree";

            //if (cvar is CCharacterResource) return "";// unused
            //if (cvar is CCollisionMesh) return "";// unused
            //if (cvar is CCommonGameResource) return "";// unused
            if (cvar is CCommunity)
                return "w2comm";
            if (cvar is CDLCDefinition)
                return "reddlc";
            //if (cvar is CDynamicLayer) return "";// unused

            if (cvar is CEntityExternalAppearance)
                return "w3app";
            if (cvar is CEntityMapPinsResource)
                return "w2em";
            if (cvar is CEnvironmentDefinition)
                return "env";
            if (cvar is CFormation)
                return "formation";
            if (cvar is CFurMeshResource)
                return "redfur";
            //if (cvar is CGameResource) return "";// unused
            if (cvar is CGuiConfigResource)
                return "guiconfig";
            if (cvar is CHudResource)
                return "hud";
            if (cvar is CJobTree)
                return "w2job";
            if (cvar is CJournalInitialEntriesResource)
                return "w2je";
            if (cvar is CJournalResource)
                return "journal";
            if (cvar is CLayer)
                return "w2l";
            if (cvar is CMenuResource)
                return "menu";
            //if (cvar is CMeshTypeResource) return "";// unused
            if (cvar is CMimicFace)
                return "w3fac";
            //if (cvar is CMimicFaces) return "";// unused
            //if (cvar is CModConverter) return "";// unused
            if (cvar is CMoveSteeringBehavior)
                return "w2steer";
            //if (cvar is CNavmesh) return "";// unused
            if (cvar is CPopupResource)
                return "popup";
            if (cvar is CQuest)
                return "w2quest";
            if (cvar is CQuestMapPinsResource)
                return "w2qm";
            if (cvar is CQuestPhase)
                return "w2phase";
            if (cvar is CResourceSimplexTree)
                return "w3simplex";
            //if (cvar is CRewardGroup) return "";// unused
            //if (cvar is CSourceTexture) return "";// unused
            if (cvar is CSpawnTree)
                return "spawntree";
            //if (cvar is CSRTBaseTree) return "";// unused

            if (cvar is CStoryScene)
                return "w2scene";

            if (cvar is CSwitchableFoliageResource)
                return "w2sf";
            //if (cvar is CUnknownResource) return "";// unused
            if (cvar is CVegetationBrush)
                return "vbrush";
            if (cvar is CWitcherGameResource)
                return "redgame";
            if (cvar is CWizardDefinition)
                return "wizdef";
            //if (cvar is CWorld) return "";// unused
            //if (cvar is CWorldMap) return "";// unused
            //if (cvar is IGuiResource) return "";
            //if (cvar is IMaterial) return "";
            //if (cvar is IMaterialDefinition) return "";
            //if (cvar is ITexture) return "";

            return "";
        }

    }
}
