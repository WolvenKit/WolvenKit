using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestObjectiveCounterGraphBlock : CQuestGraphBlock
	{
		[RED("manualObjective")] 		public CHandle<CJournalPath> ManualObjective { get; set;}

		[RED("showInfoOnScreen")] 		public CBool ShowInfoOnScreen { get; set;}

		public CJournalQuestObjectiveCounterGraphBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalQuestObjectiveCounterGraphBlock(cr2w);

	}
}