using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STargetingInfo : CVariable
	{
		[Ordinal(1)] [RED("source")] 		public CHandle<CActor> Source { get; set;}

		[Ordinal(2)] [RED("targetEntity")] 		public CHandle<CGameplayEntity> TargetEntity { get; set;}

		[Ordinal(3)] [RED("canBeTargetedCheck")] 		public CBool CanBeTargetedCheck { get; set;}

		[Ordinal(4)] [RED("coneCheck")] 		public CBool ConeCheck { get; set;}

		[Ordinal(5)] [RED("coneHalfAngleCos")] 		public CFloat ConeHalfAngleCos { get; set;}

		[Ordinal(6)] [RED("coneDist")] 		public CFloat ConeDist { get; set;}

		[Ordinal(7)] [RED("coneHeadingVector")] 		public Vector ConeHeadingVector { get; set;}

		[Ordinal(8)] [RED("distCheck")] 		public CBool DistCheck { get; set;}

		[Ordinal(9)] [RED("invisibleCheck")] 		public CBool InvisibleCheck { get; set;}

		[Ordinal(10)] [RED("navMeshCheck")] 		public CBool NavMeshCheck { get; set;}

		[Ordinal(11)] [RED("inFrameCheck")] 		public CBool InFrameCheck { get; set;}

		[Ordinal(12)] [RED("frameScaleX")] 		public CFloat FrameScaleX { get; set;}

		[Ordinal(13)] [RED("frameScaleY")] 		public CFloat FrameScaleY { get; set;}

		[Ordinal(14)] [RED("knockDownCheck")] 		public CBool KnockDownCheck { get; set;}

		[Ordinal(15)] [RED("knockDownCheckDist")] 		public CFloat KnockDownCheckDist { get; set;}

		[Ordinal(16)] [RED("rsHeadingCheck")] 		public CBool RsHeadingCheck { get; set;}

		[Ordinal(17)] [RED("rsHeadingLimitCos")] 		public CFloat RsHeadingLimitCos { get; set;}

		public STargetingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STargetingInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}