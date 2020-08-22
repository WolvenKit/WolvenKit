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
		[RED("source")] 		public CHandle<CActor> Source { get; set;}

		[RED("targetEntity")] 		public CHandle<CGameplayEntity> TargetEntity { get; set;}

		[RED("canBeTargetedCheck")] 		public CBool CanBeTargetedCheck { get; set;}

		[RED("coneCheck")] 		public CBool ConeCheck { get; set;}

		[RED("coneHalfAngleCos")] 		public CFloat ConeHalfAngleCos { get; set;}

		[RED("coneDist")] 		public CFloat ConeDist { get; set;}

		[RED("coneHeadingVector")] 		public Vector ConeHeadingVector { get; set;}

		[RED("distCheck")] 		public CBool DistCheck { get; set;}

		[RED("invisibleCheck")] 		public CBool InvisibleCheck { get; set;}

		[RED("navMeshCheck")] 		public CBool NavMeshCheck { get; set;}

		[RED("inFrameCheck")] 		public CBool InFrameCheck { get; set;}

		[RED("frameScaleX")] 		public CFloat FrameScaleX { get; set;}

		[RED("frameScaleY")] 		public CFloat FrameScaleY { get; set;}

		[RED("knockDownCheck")] 		public CBool KnockDownCheck { get; set;}

		[RED("knockDownCheckDist")] 		public CFloat KnockDownCheckDist { get; set;}

		[RED("rsHeadingCheck")] 		public CBool RsHeadingCheck { get; set;}

		[RED("rsHeadingLimitCos")] 		public CFloat RsHeadingLimitCos { get; set;}

		public STargetingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STargetingInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}