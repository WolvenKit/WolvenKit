using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkatingMovementParams : CVariable
	{
		[Ordinal(1)] [RED("accel")] 		public CFloat Accel { get; set;}

		[Ordinal(2)] [RED("decel")] 		public CFloat Decel { get; set;}

		[Ordinal(3)] [RED("decelMaxSpeed")] 		public CFloat DecelMaxSpeed { get; set;}

		[Ordinal(4)] [RED("brake")] 		public CFloat Brake { get; set;}

		[Ordinal(5)] [RED("brakeBaseSpeed")] 		public CFloat BrakeBaseSpeed { get; set;}

		[Ordinal(6)] [RED("frictionSquare")] 		public CFloat FrictionSquare { get; set;}

		[Ordinal(7)] [RED("frictionLinear")] 		public CFloat FrictionLinear { get; set;}

		[Ordinal(8)] [RED("frictionConst")] 		public CFloat FrictionConst { get; set;}

		[Ordinal(9)] [RED("turnCurve")] 		public CHandle<CCurve> TurnCurve { get; set;}

		[Ordinal(10)] [RED("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(11)] [RED("turnToGravity")] 		public CFloat TurnToGravity { get; set;}

		[Ordinal(12)] [RED("gravitySpeedMax")] 		public CFloat GravitySpeedMax { get; set;}

		public SSkatingMovementParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkatingMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}