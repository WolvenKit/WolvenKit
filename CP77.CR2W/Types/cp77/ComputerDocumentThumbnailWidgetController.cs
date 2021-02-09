using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerDocumentThumbnailWidgetController : DeviceButtonLogicControllerBase
	{
		[Ordinal(16)]  [RED("documentIconWidget")] public inkImageWidgetReference DocumentIconWidget { get; set; }
		[Ordinal(17)]  [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(18)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(19)]  [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }

		public ComputerDocumentThumbnailWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
