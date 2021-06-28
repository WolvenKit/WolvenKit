using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimationAttackTrajectoryParam : ISkeletalAnimationSetEntryParam
	{
		[Ordinal(1)] [RED("tagId")] 		public CName TagId { get; set;}

		[Ordinal(2)] [RED("type")] 		public CEnum<EAnimationAttackType> Type { get; set;}

		[Ordinal(3)] [RED("slowMotionTimeFactor")] 		public CFloat SlowMotionTimeFactor { get; set;}

		[Ordinal(4)] [RED("hitDuration")] 		public CFloat HitDuration { get; set;}

		[Ordinal(5)] [RED("postHitEnd")] 		public CFloat PostHitEnd { get; set;}

		[Ordinal(6)] [RED("slowMotionStart")] 		public CFloat SlowMotionStart { get; set;}

		[Ordinal(7)] [RED("slowMotionEnd")] 		public CFloat SlowMotionEnd { get; set;}

		[Ordinal(8)] [RED("dampOutEnd")] 		public CFloat DampOutEnd { get; set;}

		public CSkeletalAnimationAttackTrajectoryParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}