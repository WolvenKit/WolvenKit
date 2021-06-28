using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ParticleBurst : CVariable
	{
		[Ordinal(1)] [RED("burstTime")] 		public CFloat BurstTime { get; set;}

		[Ordinal(2)] [RED("spawnCount")] 		public CUInt32 SpawnCount { get; set;}

		[Ordinal(3)] [RED("spawnTimeRange")] 		public CFloat SpawnTimeRange { get; set;}

		[Ordinal(4)] [RED("repeatTime")] 		public CFloat RepeatTime { get; set;}

		public ParticleBurst(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}