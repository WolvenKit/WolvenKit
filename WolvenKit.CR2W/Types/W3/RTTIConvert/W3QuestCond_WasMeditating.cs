using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_WasMeditating : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("hours")] 		public CInt32 Hours { get; set;}

		[Ordinal(0)] [RED("("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(0)] [RED("("dayPart")] 		public CEnum<EDayPart> DayPart { get; set;}

		[Ordinal(0)] [RED("("meditateToHour")] 		public CBool MeditateToHour { get; set;}

		[Ordinal(0)] [RED("("immediateTest")] 		public CBool ImmediateTest { get; set;}

		[Ordinal(0)] [RED("("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(0)] [RED("("listener")] 		public CHandle<W3QuestCond_WasMeditating_Listener> Listener { get; set;}

		[Ordinal(0)] [RED("("factsNames", 2,0)] 		public CArray<CString> FactsNames { get; set;}

		public W3QuestCond_WasMeditating(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_WasMeditating(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}