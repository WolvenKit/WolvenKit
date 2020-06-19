using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkatingMovementParams : CVariable
	{
		[RED("accel")] 		public CFloat Accel { get; set;}

		[RED("decel")] 		public CFloat Decel { get; set;}

		[RED("decelMaxSpeed")] 		public CFloat DecelMaxSpeed { get; set;}

		[RED("brake")] 		public CFloat Brake { get; set;}

		[RED("brakeBaseSpeed")] 		public CFloat BrakeBaseSpeed { get; set;}

		[RED("frictionSquare")] 		public CFloat FrictionSquare { get; set;}

		[RED("frictionLinear")] 		public CFloat FrictionLinear { get; set;}

		[RED("frictionConst")] 		public CFloat FrictionConst { get; set;}

		[RED("turnCurve")] 		public CHandle<CCurve> TurnCurve { get; set;}

		[RED("gravity")] 		public CFloat Gravity { get; set;}

		[RED("turnToGravity")] 		public CFloat TurnToGravity { get; set;}

		[RED("gravitySpeedMax")] 		public CFloat GravitySpeedMax { get; set;}

		public SSkatingMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkatingMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}