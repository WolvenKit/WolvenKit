using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerSpawnLimitMonitor : ISpawnTreeSpawnMonitorBaseInitializer
	{
		[RED("totalSpawnLimitMin")] 		public CUInt16 TotalSpawnLimitMin { get; set;}

		[RED("totalSpawnLimitMax")] 		public CUInt16 TotalSpawnLimitMax { get; set;}

		[RED("creatureDefinition")] 		public CName CreatureDefinition { get; set;}

		[RED("resetOnFullRespawn")] 		public CBool ResetOnFullRespawn { get; set;}

		public CSpawnTreeInitializerSpawnLimitMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeInitializerSpawnLimitMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}