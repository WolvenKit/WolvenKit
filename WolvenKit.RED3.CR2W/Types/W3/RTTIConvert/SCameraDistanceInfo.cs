using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraDistanceInfo : CVariable
	{
		[Ordinal(1)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[Ordinal(3)] [RED("enemiesMaxDistanceToCamera")] 		public CFloat EnemiesMaxDistanceToCamera { get; set;}

		[Ordinal(4)] [RED("enemiesMaxDistanceToPlayer")] 		public CFloat EnemiesMaxDistanceToPlayer { get; set;}

		[Ordinal(5)] [RED("standardDeviationRelevance")] 		public CFloat StandardDeviationRelevance { get; set;}

		[Ordinal(6)] [RED("cameraZOffset")] 		public CFloat CameraZOffset { get; set;}

		[Ordinal(7)] [RED("cameraZOffsetRange")] 		public CFloat CameraZOffsetRange { get; set;}

		public SCameraDistanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraDistanceInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}