using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTStrafeSurroundTarget : IMoveTargetSteeringTask
	{
		[RED("importance")] 		public CFloat Importance { get; set;}

		[RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("desiredSeparationAngle")] 		public CFloat DesiredSeparationAngle { get; set;}

		[RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[RED("smoothAngle")] 		public CFloat SmoothAngle { get; set;}

		[RED("strafingRing")] 		public CInt32 StrafingRing { get; set;}

		[RED("gravityToSeparationAngle")] 		public CBool GravityToSeparationAngle { get; set;}

		public CMoveSTStrafeSurroundTarget(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTStrafeSurroundTarget(cr2w);

	}
}