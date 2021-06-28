using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_WasMeditating : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("hours")] 		public CInt32 Hours { get; set;}

		[Ordinal(2)] [RED("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(3)] [RED("dayPart")] 		public CEnum<EDayPart> DayPart { get; set;}

		[Ordinal(4)] [RED("meditateToHour")] 		public CBool MeditateToHour { get; set;}

		[Ordinal(5)] [RED("immediateTest")] 		public CBool ImmediateTest { get; set;}

		[Ordinal(6)] [RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(7)] [RED("listener")] 		public CHandle<W3QuestCond_WasMeditating_Listener> Listener { get; set;}

		[Ordinal(8)] [RED("factsNames", 2,0)] 		public CArray<CString> FactsNames { get; set;}

		public W3QuestCond_WasMeditating(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}