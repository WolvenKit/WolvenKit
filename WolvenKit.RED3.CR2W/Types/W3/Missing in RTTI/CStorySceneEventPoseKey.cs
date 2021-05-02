using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventPoseKey : CStorySceneEventDuration
	{
		[Ordinal(0)] [RED("actor")] public CName Actor { get; set; }

		[Ordinal(1)] [RED("blendIn")] public CFloat BlendIn { get; set; }

		[Ordinal(2)] [RED("blendOut")] public CFloat BlendOut { get; set; }

		[Ordinal(3)] [RED("weightBlendType")] public CEnum<EInterpolationType> WeightBlendType { get; set; }

		[Ordinal(4)] [RED("weight")] public CFloat Weight { get; set; }

		[Ordinal(5)] [RED("useWeightCurve")] public CBool UseWeightCurve { get; set; }

		[Ordinal(6)] [RED("weightCurve")] public SCurveData WeightCurve { get; set; }

		[Ordinal(7)] [RED("linkToDialogset")] public CBool LinkToDialogset { get; set; }

		[Ordinal(8)] [RED("version")] public CInt32 Version { get; set; }

		[Ordinal(9)] [RED("bones", 2, 0)] public CArray<SSSBoneTransform> Bones { get; set; }

		[Ordinal(10)] [RED("bonesHands", 2, 0)] public CArray<SSSBoneTransform> BonesHands { get; set; }

		[Ordinal(11)] [RED("cachedBonesIK", 2, 0)] public CArray<CInt32> CachedBonesIK { get; set; }

		[Ordinal(12)] [RED("cachedTransformsIK", 133, 0)] public CArray<EngineQsTransform> CachedTransformsIK { get; set; }

		[Ordinal(13)] [RED("presetName")] public CName PresetName { get; set; }

		[Ordinal(14)] [RED("presetVersion")] public CInt32 PresetVersion { get; set; }

		[Ordinal(15)] [RED("cachedBones", 2, 0)] public CArray<CInt32> CachedBones { get; set; }

		[Ordinal(16)] [RED("cachedTransforms", 133, 0)] public CArray<EngineQsTransform> CachedTransforms { get; set; }

		[Ordinal(17)] [RED("editorCachedHandTracks", 2, 0)] public CArray<CFloat> EditorCachedHandTracks { get; set; }

		[Ordinal(18)] [RED("editorCachedIkEffectorsID", 2, 0)] public CArray<CInt32> EditorCachedIkEffectorsID { get; set; }

		[Ordinal(19)] [RED("editorCachedIkEffectorsPos", 2, 0)] public CArray<Vector> EditorCachedIkEffectorsPos { get; set; }

		[Ordinal(20)] [RED("editorCachedIkEffectorsWeight", 2, 0)] public CArray<CFloat> EditorCachedIkEffectorsWeight { get; set; }

		[Ordinal(21)] [RED("tracks", 2, 0)] public CArray<SSSTrackTransform> Tracks { get; set; }

		[Ordinal(22)] [RED("cachedTracks", 2, 0)] public CArray<CInt32> CachedTracks { get; set; }

		[Ordinal(23)] [RED("cachedTracksValues", 2, 0)] public CArray<CFloat> CachedTracksValues { get; set; }

		[Ordinal(24)] [RED("editorCachedMimicSliders", 2, 0)] public CArray<CFloat> EditorCachedMimicSliders { get; set; }


		public CStorySceneEventPoseKey(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}