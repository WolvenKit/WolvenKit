using System.IO;using System.Runtime.Serialization;
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

		[RED("weightBlendType")] 		public EInterpolationType WeightBlendType { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[RED("linkToDialogset")] 		public CBool LinkToDialogset { get; set;}

		[RED("version")] 		public CInt32 Version { get; set;}

		[RED("cachedBones", 2,0)] 		public CArray<CInt32> CachedBones { get; set;}

		[RED("cachedTransforms", 133,0)] 		public CArray<EngineQsTransform> CachedTransforms { get; set;}

		[RED("cachedTracks", 2,0)] 		public CArray<CInt32> CachedTracks { get; set;}

		[RED("cachedTracksValues", 2,0)] 		public CArray<CFloat> CachedTracksValues { get; set;}

		public CStorySceneEventPoseKey(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventPoseKey(cr2w);

	}
}