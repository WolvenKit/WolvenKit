using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkatingMovementParams : CVariable
	{
		[Ordinal(0)] [RED("("accel")] 		public CFloat Accel { get; set;}

		[Ordinal(0)] [RED("("decel")] 		public CFloat Decel { get; set;}

		[Ordinal(0)] [RED("("decelMaxSpeed")] 		public CFloat DecelMaxSpeed { get; set;}

		[Ordinal(0)] [RED("("brake")] 		public CFloat Brake { get; set;}

		[Ordinal(0)] [RED("("brakeBaseSpeed")] 		public CFloat BrakeBaseSpeed { get; set;}

		[Ordinal(0)] [RED("("frictionSquare")] 		public CFloat FrictionSquare { get; set;}

		[Ordinal(0)] [RED("("frictionLinear")] 		public CFloat FrictionLinear { get; set;}

		[Ordinal(0)] [RED("("frictionConst")] 		public CFloat FrictionConst { get; set;}

		[Ordinal(0)] [RED("("turnCurve")] 		public CHandle<CCurve> TurnCurve { get; set;}

		[Ordinal(0)] [RED("("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(0)] [RED("("turnToGravity")] 		public CFloat TurnToGravity { get; set;}

		[Ordinal(0)] [RED("("gravitySpeedMax")] 		public CFloat GravitySpeedMax { get; set;}

		public SSkatingMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkatingMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}