using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SpawnedCounterByEntryCondition : ISpawnScriptCondition
	{
		[Ordinal(1)] [RED("spawnedValue")] 		public CInt32 SpawnedValue { get; set;}

		[Ordinal(2)] [RED("entryName")] 		public CName EntryName { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("spawnedCreatures")] 		public CInt32 SpawnedCreatures { get; set;}

		[Ordinal(5)] [RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3SpawnedCounterByEntryCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}