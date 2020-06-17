using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ParticleBurst : CVariable
	{
		[RED("burstTime")] 		public CFloat BurstTime { get; set;}

		[RED("spawnCount")] 		public CUInt32 SpawnCount { get; set;}

		[RED("spawnTimeRange")] 		public CFloat SpawnTimeRange { get; set;}

		[RED("repeatTime")] 		public CFloat RepeatTime { get; set;}

		public ParticleBurst(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new ParticleBurst(cr2w);

	}
}