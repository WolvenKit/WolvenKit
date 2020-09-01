using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeRiftSpawnedCounterMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
	{
		[Ordinal(0)] [RED("("riftTag")] 		public CName RiftTag { get; set;}

		[Ordinal(0)] [RED("("spawnLimit")] 		public CInt32 SpawnLimit { get; set;}

		public CSpawnTreeRiftSpawnedCounterMonitorInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeRiftSpawnedCounterMonitorInitializer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}