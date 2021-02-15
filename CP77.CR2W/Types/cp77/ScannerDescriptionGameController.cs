using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDescriptionGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(6)] [RED("customDescriptionText")] public inkTextWidgetReference CustomDescriptionText { get; set; }
		[Ordinal(7)] [RED("descriptionCallbackID")] public CUInt32 DescriptionCallbackID { get; set; }
		[Ordinal(8)] [RED("isValidDescription")] public CBool IsValidDescription { get; set; }
		[Ordinal(9)] [RED("isValidCustomDescription")] public CBool IsValidCustomDescription { get; set; }

		public ScannerDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
