using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STargetingInfo : CVariable
	{
		[Ordinal(0)] [RED("("source")] 		public CHandle<CActor> Source { get; set;}

		[Ordinal(0)] [RED("("targetEntity")] 		public CHandle<CGameplayEntity> TargetEntity { get; set;}

		[Ordinal(0)] [RED("("canBeTargetedCheck")] 		public CBool CanBeTargetedCheck { get; set;}

		[Ordinal(0)] [RED("("coneCheck")] 		public CBool ConeCheck { get; set;}

		[Ordinal(0)] [RED("("coneHalfAngleCos")] 		public CFloat ConeHalfAngleCos { get; set;}

		[Ordinal(0)] [RED("("coneDist")] 		public CFloat ConeDist { get; set;}

		[Ordinal(0)] [RED("("coneHeadingVector")] 		public Vector ConeHeadingVector { get; set;}

		[Ordinal(0)] [RED("("distCheck")] 		public CBool DistCheck { get; set;}

		[Ordinal(0)] [RED("("invisibleCheck")] 		public CBool InvisibleCheck { get; set;}

		[Ordinal(0)] [RED("("navMeshCheck")] 		public CBool NavMeshCheck { get; set;}

		[Ordinal(0)] [RED("("inFrameCheck")] 		public CBool InFrameCheck { get; set;}

		[Ordinal(0)] [RED("("frameScaleX")] 		public CFloat FrameScaleX { get; set;}

		[Ordinal(0)] [RED("("frameScaleY")] 		public CFloat FrameScaleY { get; set;}

		[Ordinal(0)] [RED("("knockDownCheck")] 		public CBool KnockDownCheck { get; set;}

		[Ordinal(0)] [RED("("knockDownCheckDist")] 		public CFloat KnockDownCheckDist { get; set;}

		[Ordinal(0)] [RED("("rsHeadingCheck")] 		public CBool RsHeadingCheck { get; set;}

		[Ordinal(0)] [RED("("rsHeadingLimitCos")] 		public CFloat RsHeadingLimitCos { get; set;}

		public STargetingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STargetingInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}