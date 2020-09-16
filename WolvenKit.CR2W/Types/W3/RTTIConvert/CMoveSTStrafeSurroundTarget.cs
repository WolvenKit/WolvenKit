using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTStrafeSurroundTarget : IMoveTargetSteeringTask
	{
		[Ordinal(1)] [RED("importance")] 		public CFloat Importance { get; set;}

		[Ordinal(2)] [RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[Ordinal(3)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(4)] [RED("desiredSeparationAngle")] 		public CFloat DesiredSeparationAngle { get; set;}

		[Ordinal(5)] [RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[Ordinal(6)] [RED("smoothAngle")] 		public CFloat SmoothAngle { get; set;}

		[Ordinal(7)] [RED("strafingRing")] 		public CInt32 StrafingRing { get; set;}

		[Ordinal(8)] [RED("gravityToSeparationAngle")] 		public CBool GravityToSeparationAngle { get; set;}

		public CMoveSTStrafeSurroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTStrafeSurroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}