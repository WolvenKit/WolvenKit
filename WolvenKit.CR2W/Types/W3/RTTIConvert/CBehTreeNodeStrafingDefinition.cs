using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeStrafingDefinition : CBehTreeNodeCustomSteeringDefinition
	{
		[Ordinal(0)] [RED("updateFrequency")] 		public CBehTreeValFloat UpdateFrequency { get; set;}

		[Ordinal(0)] [RED("steeringSpeed")] 		public CBehTreeValFloat SteeringSpeed { get; set;}

		[Ordinal(0)] [RED("steeringImportance")] 		public CBehTreeValFloat SteeringImportance { get; set;}

		[Ordinal(0)] [RED("accelerationRate")] 		public CBehTreeValFloat AccelerationRate { get; set;}

		[Ordinal(0)] [RED("strafingWeight")] 		public CBehTreeValFloat StrafingWeight { get; set;}

		[Ordinal(0)] [RED("keepDistanceWeight")] 		public CBehTreeValFloat KeepDistanceWeight { get; set;}

		[Ordinal(0)] [RED("randomStrafeWeight")] 		public CBehTreeValFloat RandomStrafeWeight { get; set;}

		[Ordinal(0)] [RED("randomizationFrequency")] 		public CBehTreeValFloat RandomizationFrequency { get; set;}

		[Ordinal(0)] [RED("minRange")] 		public CBehTreeValFloat MinRange { get; set;}

		[Ordinal(0)] [RED("maxRange")] 		public CBehTreeValFloat MaxRange { get; set;}

		[Ordinal(0)] [RED("desiredSeparationAngle")] 		public CBehTreeValFloat DesiredSeparationAngle { get; set;}

		[Ordinal(0)] [RED("gravityToSeparationAngle")] 		public CBehTreeValBool GravityToSeparationAngle { get; set;}

		[Ordinal(0)] [RED("lockOrientation")] 		public CBehTreeValBool LockOrientation { get; set;}

		[Ordinal(0)] [RED("strafingRing")] 		public CBehTreeValInt StrafingRing { get; set;}

		[Ordinal(0)] [RED("customAlgorithm")] 		public CPtr<CBehTreeStrafingAlgorithmDefinition> CustomAlgorithm { get; set;}

		public CBehTreeNodeStrafingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeStrafingDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}