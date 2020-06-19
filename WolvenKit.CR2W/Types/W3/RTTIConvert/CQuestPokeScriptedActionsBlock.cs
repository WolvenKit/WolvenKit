using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestPokeScriptedActionsBlock : CQuestGraphBlock
	{
		[RED("npcTag")] 		public CName NpcTag { get; set;}

		[RED("pokeEvent")] 		public CName PokeEvent { get; set;}

		[RED("handleBehaviorOutcome")] 		public CBool HandleBehaviorOutcome { get; set;}

		[RED("onlyOneActor")] 		public CBool OnlyOneActor { get; set;}

		public CQuestPokeScriptedActionsBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestPokeScriptedActionsBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}