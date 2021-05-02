using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerSpawnLimitMonitor : ISpawnTreeSpawnMonitorBaseInitializer
	{
		[Ordinal(1)] [RED("totalSpawnLimitMin")] 		public CUInt16 TotalSpawnLimitMin { get; set;}

		[Ordinal(2)] [RED("totalSpawnLimitMax")] 		public CUInt16 TotalSpawnLimitMax { get; set;}

		[Ordinal(3)] [RED("creatureDefinition")] 		public CName CreatureDefinition { get; set;}

		[Ordinal(4)] [RED("resetOnFullRespawn")] 		public CBool ResetOnFullRespawn { get; set;}

		public CSpawnTreeInitializerSpawnLimitMonitor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeInitializerSpawnLimitMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}