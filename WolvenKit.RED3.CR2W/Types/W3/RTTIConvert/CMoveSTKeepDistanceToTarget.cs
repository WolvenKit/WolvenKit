using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTKeepDistanceToTarget : IMoveTargetPositionSteeringTask
	{
		[Ordinal(1)] [RED("importance")] 		public CFloat Importance { get; set;}

		[Ordinal(2)] [RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[Ordinal(3)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(4)] [RED("minRange")] 		public CFloat MinRange { get; set;}

		[Ordinal(5)] [RED("maxRange")] 		public CFloat MaxRange { get; set;}

		[Ordinal(6)] [RED("tolerance")] 		public CFloat Tolerance { get; set;}

		[Ordinal(7)] [RED("brakeDistance")] 		public CFloat BrakeDistance { get; set;}

		[Ordinal(8)] [RED("randomizationFrequency")] 		public CFloat RandomizationFrequency { get; set;}

		public CMoveSTKeepDistanceToTarget(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTKeepDistanceToTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}