using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAnimClip : CStorySceneEventDuration
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("clipFront")] 		public CFloat ClipFront { get; set;}

		[RED("clipEnd")] 		public CFloat ClipEnd { get; set;}

		[RED("stretch")] 		public CFloat Stretch { get; set;}

		[RED("allowLookatsLevel")] 		public ELookAtLevel AllowLookatsLevel { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("forceAnimationTimeFlag")] 		public CBool ForceAnimationTimeFlag { get; set;}

		[RED("forceAnimationTime")] 		public CFloat ForceAnimationTime { get; set;}

		[RED("voiceWeightCurve")] 		public SVoiceWeightCurve VoiceWeightCurve { get; set;}

		[RED("allowPoseCorrection")] 		public CBool AllowPoseCorrection { get; set;}

		public CStorySceneEventAnimClip(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventAnimClip(cr2w);

	}
}