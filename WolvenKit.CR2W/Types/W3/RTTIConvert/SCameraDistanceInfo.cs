using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraDistanceInfo : CVariable
	{
		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[RED("enemiesMaxDistanceToCamera")] 		public CFloat EnemiesMaxDistanceToCamera { get; set;}

		[RED("enemiesMaxDistanceToPlayer")] 		public CFloat EnemiesMaxDistanceToPlayer { get; set;}

		[RED("standardDeviationRelevance")] 		public CFloat StandardDeviationRelevance { get; set;}

		[RED("cameraZOffset")] 		public CFloat CameraZOffset { get; set;}

		[RED("cameraZOffsetRange")] 		public CFloat CameraZOffsetRange { get; set;}

		public SCameraDistanceInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCameraDistanceInfo(cr2w);

	}
}