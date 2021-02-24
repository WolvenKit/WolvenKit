using DotNetHelper.FastMember.Extension.Extension;
using FastMember;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WolvenKit.CR2W.Types;


namespace WolvenKit.CR2W.Reflection
{
    /// <summary>
    /// Provides static methods for reading .NET runtime information 
    /// and converting to redengine compatible representations.
    /// </summary>
    public static class REDReflection
    {
        public static string GetREDNameString(Member item)
        {
            var attribute = item.GetMemberAttribute<REDAttribute>();
            if (attribute is null || string.IsNullOrWhiteSpace(attribute.Name))
            {
                return item.Name;
            }
            return attribute.Name;
        }

        public static string GetREDTypeString(Type type, params int[] flags)
        {
            return GetREDTypeString(type, flags.AsEnumerable().GetEnumerator());
        }

        private static string GetREDTypeString(Type type, IEnumerator<int> flags)
        {
            // FIXME wkit doesn't support .NET types right now

            
            // Handles .Net types that have different names.
            // Types such as Double, Int32, or Int16 are the same.
            //switch (Type.GetTypeCode(type))
            //{
            //    case TypeCode.Byte:    return "Uint8";
            //    case TypeCode.UInt16:  return "Uint16";
            //    case TypeCode.UInt32:  return "Uint32";
            //    case TypeCode.UInt64:  return "Uint64";
            //    case TypeCode.SByte:   return "Int8";
            //    case TypeCode.Boolean: return "Bool";
            //    case TypeCode.Single:  return "Float";
            //}

            //// Handles arrays, such as [5]Float, in C++ these would be defined fixed arrays.
            //// Here the size will be defined in the attribute, as C# can't define fixed arrays in classes like C++
            //if (type.IsArray)
            //{
            //    var arrProp = type.GetElementType();
            //    var size = flags.MoveNext() ? flags.Current : 0;
            //    return $"[{size}]{GetREDTypeString(arrProp, flags)}";
            //}

            // Handles the 5 generic types: array:2,0,Int8, ptr:CObject, 
            // static:4,Int32, handle:ISerializable and soft:CResource.
            if (type.IsGenericType)
            {
                var genprop = type.GetTypeInfo().GenericTypeArguments[0];
                var gentype = type.GetGenericTypeDefinition();
                if (gentype == typeof(CArray<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    var v2 = flags.MoveNext() ? flags.Current : 0;
                    return $"array:{v1},{v2},{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CArrayFixedSize<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"[{v1}]{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CPtr<>))
                {
                    return $"ptr:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CSoft<>))
                {
                    return $"soft:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CHandle<>))
                {
                    return $"handle:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CStatic<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"static:{v1},{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CEnum<>))
                {
                    
                }

                return type.GetPrettyGenericTypes();
            }
            else
            {
                return GetREDTypeFroWkitType(type.Name);
                
            }
        }

        public static string GetWKitBaseTypeFromREDBaseType(string typename)
        {
            switch (typename)
            {
                case "Uint8": return "CUInt8";
                case "Int8": return "CInt8";
                case "Uint16": return "CUInt16";
                case "Int16": return "CInt16";
                case "Uint32": return "CUInt32";
                case "int": return "CInt32";
                case "Int32": return "CInt32";
                case "Uint64": return "CUInt64";
                case "Int64": return "CInt64";
                case "Bool": return "CBool";
                case "bool": return "CBool";
                case "Float": return "CFloat";
                case "float": return "CFloat";
                case "String": return "CString";
                case "string": return "CString";
                case "Color": return "CColor";
                case "Matrix": return "CMatrix";
                default:
                {
                    return typename;
                }
                    
            }
        }

        private static string GetREDTypeFroWkitType(string typename)
        {
            switch (typename)
            {
                case "CUInt8": return "Uint8";
                case "CInt8": return "Int8";
                case "CUInt16": return "Uint16";
                case "CInt16": return "Int16";
                case "CUInt32": return "Uint32";
                case "CInt32": return "Int32";
                case "CUInt64": return "Uint64";
                case "CInt64": return "Int64";
                case "CBool": return "Bool";
                case "CFloat": return "Float";
                case "CString": return "String";
                case "CColor": return "Color";
                case "CMatrix": return "Matrix";
                default:
                    return typename;
            }
        }


        public static IEnumerable<Member> GetREDMembers(this CVariable cvar, bool includeBuffers) =>
            GetMembers(cvar)
                .Where(p =>
                {
                    var attr = p.GetMemberAttribute<REDAttribute>();
                    if (attr is null)
                    {
                        return false;
                    }

                    if (!includeBuffers)
                    {
                        return attr is not REDBufferAttribute;
                    }

                    return true;
                })
                .OrderBy(p => p.Ordinal);

        public static IEnumerable<Member> GetREDBuffers(this CVariable cvar) =>
            GetMembers(cvar)
                .Where(p => p.GetMemberAttribute<REDBufferAttribute>() is not null)
                .OrderBy(p => p.Ordinal);

        private static readonly ConcurrentDictionary<Type, Lazy<IEnumerable<Member>>> MembersCache = new();

        private static IEnumerable<Member> GetMembers(CVariable cvar) =>
            MembersCache.GetOrAdd(cvar.GetType(), new Lazy<IEnumerable<Member>>(() => GetMembersInternal(cvar))).Value;

        private static IEnumerable<Member> GetMembersInternal(CVariable cvar) => cvar.accessor.GetMembers();

        public static string GetREDExtensionFromREDType(string redtype)
        {
            switch (redtype)
            {
                //case "CResource": return "";
                case "CCookedExplorations": return "redexp";
                case "CBehaviorGraph": return "w2beh";

                case "CCharacterEntityTemplate": return "w2cent";
                case "CEntityTemplate": return "w2ent";

                case "CFoliageResource": return "flyr";
                case "CGameWorld": return "w2w";
                case "CMaterialGraph": return "w2mg";
                case "CMaterialInstance": return "w2mi";

                case "CPhysicsDestructionResource": return "reddest"; // check before mesh
                case "CMesh": return "w2mesh";

                case "CRagdoll": return "w2ragdoll";

                case "CCutsceneTemplate": return "w2cutscene";     // check before CSkeletalAnimationSet
                case "CStorySceneDialogset": return "w2dset";      // check before CSkeletalAnimationSet
                case "CSkeletalAnimationSet": return "w2anims";

                case "CExtAnimEventsFile": return "w2animev";

                case "CSwarmCellMap": return "cellmap";
                case "CSwfResource": return "redswf";

                //case "CUmbraScene": return "";           //??

                case "CWayPointsCollectionsSet": return "redwpset";
                case "CUmbraTile": return "w3occlusion";
                case "CFont": return "w2fnt";
                case "CTextureArray": return "texarray";
                case "CTerrainTile": return "w2ter";

                //case "CSwfTexture": return "redswf";     //??
                case "CBitmapTexture": return "xbm";

                case "CCubeTexture": return "w2cube";
                case "CGenericGrassMask": return "grassmask";
                case "CParticleSystem": return "w2p";

                case "CDyngResource": return "w3dyng";
                case "CSkeleton": return "w3fac"; // w3dyng // w3fac

                case "CWayPointsCollection": return "redwpset";
                //case "C2dArray": return ""; // unused
                case "CApexClothResource": return "redcloth";
                case "CApexDestructionResource": return "redapex";
                // case "CApexResource": return "";   // unused
                case "CAreaMapPinsResource": return "w2am";
                case "CBehTree": return "w2behtree";

                //case "CCharacterResource": return "";// unused
                //case "CCollisionMesh": return "";// unused
                //case "CCommonGameResource": return "";// unused
                case "CCommunity": return "w2comm";
                case "CDLCDefinition": return "reddlc";
                //case "CDynamicLayer": return "";// unused

                case "CEntityExternalAppearance": return "w3app";
                case "CEntityMapPinsResource": return "w2em";
                case "CEnvironmentDefinition": return "env";
                case "CFormation": return "formation";
                case "CFurMeshResource": return "redfur";
                //case "CGameResource": return "";// unused
                case "CGuiConfigResource": return "guiconfig";
                case "CHudResource": return "hud";
                case "CJobTree": return "w2job";
                case "CJournalInitialEntriesResource": return "w2je";
                case "CJournalResource": return "journal";
                case "CLayer": return "w2l";
                case "CMenuResource": return "menu";
                //case "CMeshTypeResource": return "";// unused
                case "CMimicFace": return "w3fac";
                //case "CMimicFaces": return "";// unused
                //case "CModConverter": return "";// unused
                case "CMoveSteeringBehavior": return "w2steer";
                //case "CNavmesh": return "";// unused
                case "CPopupResource": return "popup";
                case "CQuest": return "w2quest";
                case "CQuestMapPinsResource": return "w2qm";
                case "CQuestPhase": return "w2phase";
                case "CResourceSimplexTree": return "w3simplex";
                //case "CRewardGroup": return "";// unused
                //case "CSourceTexture": return "";// unused
                case "CSpawnTree": return "spawntree";
                //case "CSRTBaseTree": return "";// unused


                case "CStoryScene": return "w2scene";

                case "CSwitchableFoliageResource": return "w2sf";
                //case "CUnknownResource": return "";// unused
                case "CVegetationBrush": return "vbrush";
                case "CWitcherGameResource": return "redgame";
                case "CWizardDefinition": return "wizdef";
                //case "CWorld": return "";// unused
                //case "CWorldMap": return "";// unused
                //case "IGuiResource": return "";
                //case "IMaterial": return "";
                //case "IMaterialDefinition": return "";
                //case "ITexture": return "";

                default:
                    break;
            }


            return "";
        }

        public static string GetREDExtensionFromCVariable(CResource cvar)
        {
            //if (cvar is CResource) return "";
            if (cvar is CCookedExplorations) return "redexp";
            if (cvar is CBehaviorGraph) return "w2beh";

            if (cvar is CCharacterEntityTemplate) return "w2cent";
            if (cvar is CEntityTemplate) return "w2ent";

            if (cvar is CFoliageResource) return "flyr";
            if (cvar is CGameWorld) return "w2w";
            if (cvar is CMaterialGraph) return "w2mg";
            if (cvar is CMaterialInstance) return "w2mi";

            if (cvar is CPhysicsDestructionResource) return "reddest"; // check before mesh
            if (cvar is CMesh) return "w2mesh";
            
            if (cvar is CRagdoll) return "w2ragdoll";

            if (cvar is CCutsceneTemplate) return "w2cutscene";     // check before CSkeletalAnimationSet
            if (cvar is CStorySceneDialogset) return "w2dset";      // check before CSkeletalAnimationSet
            if (cvar is CSkeletalAnimationSet) return "w2anims";
            
            if (cvar is CExtAnimEventsFile) return "w2animev";

            if (cvar is CSwarmCellMap) return "cellmap";
            if (cvar is CSwfResource) return "redswf";

            //if (cvar is CUmbraScene) return "";           //??

            if (cvar is CWayPointsCollectionsSet) return "redwpset";
            if (cvar is CUmbraTile) return "w3occlusion";
            if (cvar is CFont) return "w2fnt";
            if (cvar is CTextureArray) return "texarray";
            if (cvar is CTerrainTile) return "w2ter";

            //if (cvar is CSwfTexture) return "redswf";     //??
            if (cvar is CBitmapTexture) return "xbm";

            if (cvar is CCubeTexture) return "w2cube";
            if (cvar is CGenericGrassMask) return "grassmask";
            if (cvar is CParticleSystem) return "w2p";

            if (cvar is CDyngResource) return "w3dyng";
            if (cvar is CSkeleton) return "w3fac"; // w3dyng // w3fac
            
            if (cvar is CWayPointsCollection) return "redwpset";
            //if (cvar is C2dArray) return ""; // unused
            if (cvar is CApexClothResource) return "redcloth";
            if (cvar is CApexDestructionResource) return "redapex";
           // if (cvar is CApexResource) return "";   // unused
            if (cvar is CAreaMapPinsResource) return "w2am";
            if (cvar is CBehTree) return "w2behtree";

            //if (cvar is CCharacterResource) return "";// unused
            //if (cvar is CCollisionMesh) return "";// unused
            //if (cvar is CCommonGameResource) return "";// unused
            if (cvar is CCommunity) return "w2comm";
            if (cvar is CDLCDefinition) return "reddlc";
            //if (cvar is CDynamicLayer) return "";// unused

            if (cvar is CEntityExternalAppearance) return "w3app";
            if (cvar is CEntityMapPinsResource) return "w2em";
            if (cvar is CEnvironmentDefinition) return "env";
            if (cvar is CFormation) return "formation";
            if (cvar is CFurMeshResource) return "redfur";
            //if (cvar is CGameResource) return "";// unused
            if (cvar is CGuiConfigResource) return "guiconfig";
            if (cvar is CHudResource) return "hud";
            if (cvar is CJobTree) return "w2job";
            if (cvar is CJournalInitialEntriesResource) return "w2je";
            if (cvar is CJournalResource) return "journal";
            if (cvar is CLayer) return "w2l";
            if (cvar is CMenuResource) return "menu";
            //if (cvar is CMeshTypeResource) return "";// unused
            if (cvar is CMimicFace) return "w3fac";
            //if (cvar is CMimicFaces) return "";// unused
            //if (cvar is CModConverter) return "";// unused
            if (cvar is CMoveSteeringBehavior) return "w2steer";
            //if (cvar is CNavmesh) return "";// unused
            if (cvar is CPopupResource) return "popup";
            if (cvar is CQuest) return "w2quest";
            if (cvar is CQuestMapPinsResource) return "w2qm";
            if (cvar is CQuestPhase) return "w2phase";
            if (cvar is CResourceSimplexTree) return "w3simplex";
            //if (cvar is CRewardGroup) return "";// unused
            //if (cvar is CSourceTexture) return "";// unused
            if (cvar is CSpawnTree) return "spawntree";
            //if (cvar is CSRTBaseTree) return "";// unused


            if (cvar is CStoryScene) return "w2scene";
            
            if (cvar is CSwitchableFoliageResource) return "w2sf";
            //if (cvar is CUnknownResource) return "";// unused
            if (cvar is CVegetationBrush) return "vbrush";
            if (cvar is CWitcherGameResource) return "redgame";
            if (cvar is CWizardDefinition) return "wizdef";
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
