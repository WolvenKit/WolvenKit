using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTStrafeSurroundTarget : IMoveTargetSteeringTask
	{
		[Ordinal(0)] [RED("importance")] 		public CFloat Importance { get; set;}

		[Ordinal(0)] [RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[Ordinal(0)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(0)] [RED("desiredSeparationAngle")] 		public CFloat DesiredSeparationAngle { get; set;}

		[Ordinal(0)] [RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[Ordinal(0)] [RED("smoothAngle")] 		public CFloat SmoothAngle { get; set;}

		[Ordinal(0)] [RED("strafingRing")] 		public CInt32 StrafingRing { get; set;}

		[Ordinal(0)] [RED("gravityToSeparationAngle")] 		public CBool GravityToSeparationAngle { get; set;}

		public CMoveSTStrafeSurroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTStrafeSurroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}