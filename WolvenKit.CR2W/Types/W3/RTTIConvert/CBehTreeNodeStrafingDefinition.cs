using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeStrafingDefinition : CBehTreeNodeCustomSteeringDefinition
	{
		[Ordinal(1)] [RED("updateFrequency")] 		public CBehTreeValFloat UpdateFrequency { get; set;}

		[Ordinal(2)] [RED("steeringSpeed")] 		public CBehTreeValFloat SteeringSpeed { get; set;}

		[Ordinal(3)] [RED("steeringImportance")] 		public CBehTreeValFloat SteeringImportance { get; set;}

		[Ordinal(4)] [RED("accelerationRate")] 		public CBehTreeValFloat AccelerationRate { get; set;}

		[Ordinal(5)] [RED("strafingWeight")] 		public CBehTreeValFloat StrafingWeight { get; set;}

		[Ordinal(6)] [RED("keepDistanceWeight")] 		public CBehTreeValFloat KeepDistanceWeight { get; set;}

		[Ordinal(7)] [RED("randomStrafeWeight")] 		public CBehTreeValFloat RandomStrafeWeight { get; set;}

		[Ordinal(8)] [RED("randomizationFrequency")] 		public CBehTreeValFloat RandomizationFrequency { get; set;}

		[Ordinal(9)] [RED("minRange")] 		public CBehTreeValFloat MinRange { get; set;}

		[Ordinal(10)] [RED("maxRange")] 		public CBehTreeValFloat MaxRange { get; set;}

		[Ordinal(11)] [RED("desiredSeparationAngle")] 		public CBehTreeValFloat DesiredSeparationAngle { get; set;}

		[Ordinal(12)] [RED("gravityToSeparationAngle")] 		public CBehTreeValBool GravityToSeparationAngle { get; set;}

		[Ordinal(13)] [RED("lockOrientation")] 		public CBehTreeValBool LockOrientation { get; set;}

		[Ordinal(14)] [RED("strafingRing")] 		public CBehTreeValInt StrafingRing { get; set;}

		[Ordinal(15)] [RED("customAlgorithm")] 		public CPtr<CBehTreeStrafingAlgorithmDefinition> CustomAlgorithm { get; set;}

		public CBehTreeNodeStrafingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeStrafingDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}