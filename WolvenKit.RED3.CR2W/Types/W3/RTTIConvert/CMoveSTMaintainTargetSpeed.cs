using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTMaintainTargetSpeed : IManageSpeedSteeringTask
	{
		[Ordinal(1)] [RED("allowedDiffPerSecond")] 		public CFloat AllowedDiffPerSecond { get; set;}

		[Ordinal(2)] [RED("stopSpeedThreshold")] 		public CFloat StopSpeedThreshold { get; set;}

		[Ordinal(3)] [RED("distanceCoefficient")] 		public CFloat DistanceCoefficient { get; set;}

		public CMoveSTMaintainTargetSpeed(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}