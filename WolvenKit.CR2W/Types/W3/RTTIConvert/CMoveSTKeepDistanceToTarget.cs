using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTKeepDistanceToTarget : IMoveTargetPositionSteeringTask
	{
		[RED("importance")] 		public CFloat Importance { get; set;}

		[RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("minRange")] 		public CFloat MinRange { get; set;}

		[RED("maxRange")] 		public CFloat MaxRange { get; set;}

		[RED("tolerance")] 		public CFloat Tolerance { get; set;}

		[RED("brakeDistance")] 		public CFloat BrakeDistance { get; set;}

		[RED("randomizationFrequency")] 		public CFloat RandomizationFrequency { get; set;}

		public CMoveSTKeepDistanceToTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTKeepDistanceToTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}