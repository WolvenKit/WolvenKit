using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestResetScriptedActionsBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("npcTag")] 		public CName NpcTag { get; set;}

		[Ordinal(2)] [RED("onlyOneActor")] 		public CBool OnlyOneActor { get; set;}

		public CQuestResetScriptedActionsBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestResetScriptedActionsBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}