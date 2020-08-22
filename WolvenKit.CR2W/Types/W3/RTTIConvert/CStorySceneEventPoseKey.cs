using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventPoseKey : CStorySceneEventDuration
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("weightBlendType")] 		public CEnum<EInterpolationType> WeightBlendType { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[RED("linkToDialogset")] 		public CBool LinkToDialogset { get; set;}

		[RED("version")] 		public CInt32 Version { get; set;}

		[RED("bones", 2,0)] 		public CArray<SSSBoneTransform> Bones { get; set;}

		[RED("bonesHands", 2,0)] 		public CArray<SSSBoneTransform> BonesHands { get; set;}

		[RED("cachedBonesIK", 2,0)] 		public CArray<CInt32> CachedBonesIK { get; set;}

		[RED("cachedTransformsIK", 133,0)] 		public CArray<EngineQsTransform> CachedTransformsIK { get; set;}

		[RED("presetName")] 		public CName PresetName { get; set;}

		[RED("presetVersion")] 		public CInt32 PresetVersion { get; set;}

		[RED("cachedBones", 2,0)] 		public CArray<CInt32> CachedBones { get; set;}

		[RED("cachedTransforms", 133,0)] 		public CArray<EngineQsTransform> CachedTransforms { get; set;}

		[RED("editorCachedHandTracks", 2,0)] 		public CArray<CFloat> EditorCachedHandTracks { get; set;}

		[RED("editorCachedIkEffectorsID", 2,0)] 		public CArray<CInt32> EditorCachedIkEffectorsID { get; set;}

		[RED("editorCachedIkEffectorsPos", 2,0)] 		public CArray<Vector> EditorCachedIkEffectorsPos { get; set;}

		[RED("editorCachedIkEffectorsWeight", 2,0)] 		public CArray<CFloat> EditorCachedIkEffectorsWeight { get; set;}

		[RED("tracks", 2,0)] 		public CArray<SSSTrackTransform> Tracks { get; set;}

		[RED("cachedTracks", 2,0)] 		public CArray<CInt32> CachedTracks { get; set;}

		[RED("cachedTracksValues", 2,0)] 		public CArray<CFloat> CachedTracksValues { get; set;}

		[RED("editorCachedMimicSliders", 2,0)] 		public CArray<CFloat> EditorCachedMimicSliders { get; set;}

		public CStorySceneEventPoseKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventPoseKey(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}