using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SpawnedCounterByEntryCondition : ISpawnScriptCondition
	{
		[RED("spawnedValue")] 		public CInt32 SpawnedValue { get; set;}

		[RED("entryName")] 		public CName EntryName { get; set;}

		[RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[RED("spawnedCreatures")] 		public CInt32 SpawnedCreatures { get; set;}

		[RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3SpawnedCounterByEntryCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SpawnedCounterByEntryCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}