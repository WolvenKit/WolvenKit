using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeEncunterStateByEntryMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
	{
		[Ordinal(1)] [RED("counterType")] 		public CEnum<EEncounterMonitorCounterType> CounterType { get; set;}

		[Ordinal(2)] [RED("referenceValue")] 		public CInt32 ReferenceValue { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("disableMonitorAfterTasksFinished")] 		public CBool DisableMonitorAfterTasksFinished { get; set;}

		[Ordinal(5)] [RED("factOnConditionMet")] 		public CString FactOnConditionMet { get; set;}

		[Ordinal(6)] [RED("ownerEncounterTasks", 2,0)] 		public CArray<SOwnerEncounterTaskParams> OwnerEncounterTasks { get; set;}

		[Ordinal(7)] [RED("externalEncounterTasks", 2,0)] 		public CArray<SExternalEncounterTaskParams> ExternalEncounterTasks { get; set;}

		public CSpawnTreeEncunterStateByEntryMonitorInitializer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}