using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_GameplayFact : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("gameplayFactId")] 		public CString GameplayFactId { get; set;}

		[Ordinal(0)] [RED("("value")] 		public CInt32 Value { get; set;}

		[Ordinal(0)] [RED("("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(0)] [RED("("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(0)] [RED("("listener")] 		public CHandle<W3QuestCond_GameplayFact_Listener> Listener { get; set;}

		public W3QuestCond_GameplayFact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_GameplayFact(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}