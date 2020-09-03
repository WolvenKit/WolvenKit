using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_SwitchState : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("switchTag")] 		public CName SwitchTag { get; set;}

		[Ordinal(2)] [RED("stateToCheck")] 		public CEnum<ESwitchStateCondition> StateToCheck { get; set;}

		[Ordinal(3)] [RED("switchEntity")] 		public CHandle<W3Switch> SwitchEntity { get; set;}

		[Ordinal(4)] [RED("listener")] 		public CHandle<W3QuestCond_SwitchState_Listener> Listener { get; set;}

		public W3QuestCond_SwitchState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_SwitchState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}