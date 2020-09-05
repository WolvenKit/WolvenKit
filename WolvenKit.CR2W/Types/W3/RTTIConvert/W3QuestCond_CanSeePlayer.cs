using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_CanSeePlayer : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("actorTag")] 		public CName ActorTag { get; set;}

		[Ordinal(2)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(3)] [RED("listener")] 		public CHandle<W3QuestCond_CanSeePlayer_Listener> Listener { get; set;}

		public W3QuestCond_CanSeePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_CanSeePlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}