using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkQuestMapPin : CVariable
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("questArea")] 		public CEnum<EAreaName> QuestArea { get; set;}

		[RED("questObjective")] 		public CHandle<CJournalQuestObjective> QuestObjective { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("areaPosType")] 		public CEnum<WmkAreaPositionType> AreaPosType { get; set;}

		[RED("titleStringId")] 		public CInt32 TitleStringId { get; set;}

		[RED("descriptionStringId")] 		public CInt32 DescriptionStringId { get; set;}

		[RED("questLevel")] 		public CInt32 QuestLevel { get; set;}

		public WmkQuestMapPin(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new WmkQuestMapPin(cr2w);

	}
}