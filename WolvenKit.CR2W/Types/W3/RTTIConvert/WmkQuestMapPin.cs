using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkQuestMapPin : CVariable
	{
		[Ordinal(1)] [RED("("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("("questArea")] 		public CEnum<EAreaName> QuestArea { get; set;}

		[Ordinal(3)] [RED("("questObjective")] 		public CHandle<CJournalQuestObjective> QuestObjective { get; set;}

		[Ordinal(4)] [RED("("position")] 		public Vector Position { get; set;}

		[Ordinal(5)] [RED("("areaPosType")] 		public CEnum<WmkAreaPositionType> AreaPosType { get; set;}

		[Ordinal(6)] [RED("("titleStringId")] 		public CInt32 TitleStringId { get; set;}

		[Ordinal(7)] [RED("("descriptionStringId")] 		public CInt32 DescriptionStringId { get; set;}

		[Ordinal(8)] [RED("("questLevel")] 		public CInt32 QuestLevel { get; set;}

		public WmkQuestMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WmkQuestMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}