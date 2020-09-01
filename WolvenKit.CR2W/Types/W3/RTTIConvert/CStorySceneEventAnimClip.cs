using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAnimClip : CStorySceneEventDuration
	{
		[Ordinal(1)] [RED("("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(3)] [RED("("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(4)] [RED("("clipFront")] 		public CFloat ClipFront { get; set;}

		[Ordinal(5)] [RED("("clipEnd")] 		public CFloat ClipEnd { get; set;}

		[Ordinal(6)] [RED("("stretch")] 		public CFloat Stretch { get; set;}

		[Ordinal(7)] [RED("("allowLookatsLevel")] 		public CEnum<ELookAtLevel> AllowLookatsLevel { get; set;}

		[Ordinal(8)] [RED("("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(9)] [RED("("cachedAnimationDuration")] 		public CFloat CachedAnimationDuration { get; set;}

		[Ordinal(10)] [RED("("forceAnimationTimeFlag")] 		public CBool ForceAnimationTimeFlag { get; set;}

		[Ordinal(11)] [RED("("forceAnimationTime")] 		public CFloat ForceAnimationTime { get; set;}

		[Ordinal(12)] [RED("("voiceWeightCurve")] 		public SVoiceWeightCurve VoiceWeightCurve { get; set;}

		[Ordinal(13)] [RED("("allowPoseCorrection")] 		public CBool AllowPoseCorrection { get; set;}

		public CStorySceneEventAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventAnimClip(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}