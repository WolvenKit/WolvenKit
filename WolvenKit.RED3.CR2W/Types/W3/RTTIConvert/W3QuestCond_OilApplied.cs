using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_OilApplied : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("swordType")] 		public CEnum<EQuestSword> SwordType { get; set;}

		[Ordinal(2)] [RED("oilName")] 		public CName OilName { get; set;}

		[Ordinal(3)] [RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(4)] [RED("listener")] 		public CHandle<W3QuestCond_OilApplied_Listener> Listener { get; set;}

		public W3QuestCond_OilApplied(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_OilApplied(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}