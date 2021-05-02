using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3KilledCounterByEntryCondition : ISpawnScriptCondition
	{
		[Ordinal(1)] [RED("killedValue")] 		public CInt32 KilledValue { get; set;}

		[Ordinal(2)] [RED("entryNme")] 		public CName EntryNme { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("killedCreatures")] 		public CInt32 KilledCreatures { get; set;}

		[Ordinal(5)] [RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3KilledCounterByEntryCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}