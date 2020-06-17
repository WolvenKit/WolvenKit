using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseQuestScriptedActionsBlock : CQuestGraphBlock
	{
		[RED("npcTag")] 		public CName NpcTag { get; set;}

		[RED("handleBehaviorOutcome")] 		public CBool HandleBehaviorOutcome { get; set;}

		[RED("actionsPriority")] 		public ETopLevelAIPriorities ActionsPriority { get; set;}

		[RED("onlyOneActor")] 		public CBool OnlyOneActor { get; set;}

		public CBaseQuestScriptedActionsBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBaseQuestScriptedActionsBlock(cr2w);

	}
}