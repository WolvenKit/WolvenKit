using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPoseLookAtSegmentData : CVariable
	{
		[Ordinal(1)] [RED("segmentLevel")] 		public CEnum<ELookAtLevel> SegmentLevel { get; set;}

		[Ordinal(2)] [RED("boneNameFirst")] 		public CString BoneNameFirst { get; set;}

		[Ordinal(3)] [RED("boneNameLast")] 		public CString BoneNameLast { get; set;}

		[Ordinal(4)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(5)] [RED("bendingMultiplier")] 		public CFloat BendingMultiplier { get; set;}

		[Ordinal(6)] [RED("responsiveness")] 		public CFloat Responsiveness { get; set;}

		[Ordinal(7)] [RED("propagateToChain")] 		public CBool PropagateToChain { get; set;}

		[Ordinal(8)] [RED("onlyFirst")] 		public CBool OnlyFirst { get; set;}

		[Ordinal(9)] [RED("up")] 		public CEnum<EAxis> Up { get; set;}

		[Ordinal(10)] [RED("front")] 		public CEnum<EAxis> Front { get; set;}

		[Ordinal(11)] [RED("angleMaxHor")] 		public CFloat AngleMaxHor { get; set;}

		[Ordinal(12)] [RED("angleMaxVer")] 		public CFloat AngleMaxVer { get; set;}

		[Ordinal(13)] [RED("angleThresholdDiffHor")] 		public CFloat AngleThresholdDiffHor { get; set;}

		[Ordinal(14)] [RED("angleThresholdDiffVer")] 		public CFloat AngleThresholdDiffVer { get; set;}

		[Ordinal(15)] [RED("maxAngleDiffHor")] 		public CFloat MaxAngleDiffHor { get; set;}

		[Ordinal(16)] [RED("maxAngleDiffVer")] 		public CFloat MaxAngleDiffVer { get; set;}

		[Ordinal(17)] [RED("maxAngleVerToRefPose")] 		public CFloat MaxAngleVerToRefPose { get; set;}

		[Ordinal(18)] [RED("maxAngleHorToRefPose")] 		public CFloat MaxAngleHorToRefPose { get; set;}

		public SPoseLookAtSegmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPoseLookAtSegmentData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}