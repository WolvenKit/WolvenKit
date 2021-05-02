using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_PlayerState : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("stateName")] 		public CName StateName { get; set;}

		[Ordinal(2)] [RED("playerState")] 		public CEnum<EQuestConditionPlayerState> PlayerState { get; set;}

		[Ordinal(3)] [RED("inverted")] 		public CBool Inverted { get; set;}

		public W3QuestCond_PlayerState(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_PlayerState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}