using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_IsItemUsed : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(2)] [RED("factName")] 		public CString FactName { get; set;}

		[Ordinal(3)] [RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(4)] [RED("listener")] 		public CHandle<W3QuestCond_IsItemUsed_Listener> Listener { get; set;}

		public W3QuestCond_IsItemUsed(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_IsItemUsed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}