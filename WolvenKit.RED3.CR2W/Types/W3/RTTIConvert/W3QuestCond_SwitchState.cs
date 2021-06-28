using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_SwitchState : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("switchTag")] 		public CName SwitchTag { get; set;}

		[Ordinal(2)] [RED("stateToCheck")] 		public CEnum<ESwitchStateCondition> StateToCheck { get; set;}

		[Ordinal(3)] [RED("switchEntity")] 		public CHandle<W3Switch> SwitchEntity { get; set;}

		[Ordinal(4)] [RED("listener")] 		public CHandle<W3QuestCond_SwitchState_Listener> Listener { get; set;}

		public W3QuestCond_SwitchState(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}