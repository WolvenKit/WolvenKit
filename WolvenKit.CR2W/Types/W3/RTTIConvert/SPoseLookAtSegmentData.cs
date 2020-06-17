using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPoseLookAtSegmentData : CVariable
	{
		[RED("segmentLevel")] 		public ELookAtLevel SegmentLevel { get; set;}

		[RED("boneNameFirst")] 		public CString BoneNameFirst { get; set;}

		[RED("boneNameLast")] 		public CString BoneNameLast { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("bendingMultiplier")] 		public CFloat BendingMultiplier { get; set;}

		[RED("responsiveness")] 		public CFloat Responsiveness { get; set;}

		[RED("propagateToChain")] 		public CBool PropagateToChain { get; set;}

		[RED("onlyFirst")] 		public CBool OnlyFirst { get; set;}

		[RED("up")] 		public EAxis Up { get; set;}

		[RED("front")] 		public EAxis Front { get; set;}

		[RED("angleMaxHor")] 		public CFloat AngleMaxHor { get; set;}

		[RED("angleMaxVer")] 		public CFloat AngleMaxVer { get; set;}

		[RED("angleThresholdDiffHor")] 		public CFloat AngleThresholdDiffHor { get; set;}

		[RED("angleThresholdDiffVer")] 		public CFloat AngleThresholdDiffVer { get; set;}

		[RED("maxAngleDiffHor")] 		public CFloat MaxAngleDiffHor { get; set;}

		[RED("maxAngleDiffVer")] 		public CFloat MaxAngleDiffVer { get; set;}

		[RED("maxAngleVerToRefPose")] 		public CFloat MaxAngleVerToRefPose { get; set;}

		[RED("maxAngleHorToRefPose")] 		public CFloat MaxAngleHorToRefPose { get; set;}

		public SPoseLookAtSegmentData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPoseLookAtSegmentData(cr2w);

	}
}