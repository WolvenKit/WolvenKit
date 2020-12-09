using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3KilledCounterCondition : ISpawnScriptCondition
	{
		[Ordinal(1)] [RED("killedValue")] 		public CInt32 KilledValue { get; set;}

		[Ordinal(2)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(3)] [RED("killedCreatures")] 		public CInt32 KilledCreatures { get; set;}

		[Ordinal(4)] [RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3KilledCounterCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3KilledCounterCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}