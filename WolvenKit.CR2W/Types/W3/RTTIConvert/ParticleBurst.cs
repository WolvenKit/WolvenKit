using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ParticleBurst : CVariable
	{
		[Ordinal(0)] [RED("burstTime")] 		public CFloat BurstTime { get; set;}

		[Ordinal(0)] [RED("spawnCount")] 		public CUInt32 SpawnCount { get; set;}

		[Ordinal(0)] [RED("spawnTimeRange")] 		public CFloat SpawnTimeRange { get; set;}

		[Ordinal(0)] [RED("repeatTime")] 		public CFloat RepeatTime { get; set;}

		public ParticleBurst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ParticleBurst(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}