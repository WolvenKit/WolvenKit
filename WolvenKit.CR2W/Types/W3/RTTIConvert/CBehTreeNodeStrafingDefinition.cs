using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeStrafingDefinition : CBehTreeNodeCustomSteeringDefinition
	{
		[RED("updateFrequency")] 		public CBehTreeValFloat UpdateFrequency { get; set;}

		[RED("steeringSpeed")] 		public CBehTreeValFloat SteeringSpeed { get; set;}

		[RED("steeringImportance")] 		public CBehTreeValFloat SteeringImportance { get; set;}

		[RED("accelerationRate")] 		public CBehTreeValFloat AccelerationRate { get; set;}

		[RED("strafingWeight")] 		public CBehTreeValFloat StrafingWeight { get; set;}

		[RED("keepDistanceWeight")] 		public CBehTreeValFloat KeepDistanceWeight { get; set;}

		[RED("randomStrafeWeight")] 		public CBehTreeValFloat RandomStrafeWeight { get; set;}

		[RED("randomizationFrequency")] 		public CBehTreeValFloat RandomizationFrequency { get; set;}

		[RED("minRange")] 		public CBehTreeValFloat MinRange { get; set;}

		[RED("maxRange")] 		public CBehTreeValFloat MaxRange { get; set;}

		[RED("desiredSeparationAngle")] 		public CBehTreeValFloat DesiredSeparationAngle { get; set;}

		[RED("gravityToSeparationAngle")] 		public CBehTreeValBool GravityToSeparationAngle { get; set;}

		[RED("lockOrientation")] 		public CBehTreeValBool LockOrientation { get; set;}

		[RED("strafingRing")] 		public CBehTreeValInt StrafingRing { get; set;}

		[RED("customAlgorithm")] 		public CPtr<CBehTreeStrafingAlgorithmDefinition> CustomAlgorithm { get; set;}

		public CBehTreeNodeStrafingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeStrafingDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}