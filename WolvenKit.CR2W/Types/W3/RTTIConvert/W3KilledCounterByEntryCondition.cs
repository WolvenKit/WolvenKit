using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3KilledCounterByEntryCondition : ISpawnScriptCondition
	{
		[Ordinal(0)] [RED("("killedValue")] 		public CInt32 KilledValue { get; set;}

		[Ordinal(0)] [RED("("entryNme")] 		public CName EntryNme { get; set;}

		[Ordinal(0)] [RED("("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(0)] [RED("("killedCreatures")] 		public CInt32 KilledCreatures { get; set;}

		[Ordinal(0)] [RED("("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3KilledCounterByEntryCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3KilledCounterByEntryCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}