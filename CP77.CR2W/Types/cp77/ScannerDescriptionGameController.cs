using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDescriptionGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("customDescriptionText")] public inkTextWidgetReference CustomDescriptionText { get; set; }
		[Ordinal(1)]  [RED("descriptionCallbackID")] public CUInt32 DescriptionCallbackID { get; set; }
		[Ordinal(2)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(3)]  [RED("isValidCustomDescription")] public CBool IsValidCustomDescription { get; set; }
		[Ordinal(4)]  [RED("isValidDescription")] public CBool IsValidDescription { get; set; }

		public ScannerDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
