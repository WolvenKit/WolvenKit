using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimationAttackTrajectoryParam : ISkeletalAnimationSetEntryParam
	{
		[RED("tagId")] 		public CName TagId { get; set;}

		[RED("type")] 		public EAnimationAttackType Type { get; set;}

		[RED("slowMotionTimeFactor")] 		public CFloat SlowMotionTimeFactor { get; set;}

		[RED("hitDuration")] 		public CFloat HitDuration { get; set;}

		[RED("postHitEnd")] 		public CFloat PostHitEnd { get; set;}

		[RED("slowMotionStart")] 		public CFloat SlowMotionStart { get; set;}

		[RED("slowMotionEnd")] 		public CFloat SlowMotionEnd { get; set;}

		[RED("dampOutEnd")] 		public CFloat DampOutEnd { get; set;}

		public CSkeletalAnimationAttackTrajectoryParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSkeletalAnimationAttackTrajectoryParam(cr2w);

	}
}