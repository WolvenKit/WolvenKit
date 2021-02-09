using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("thumbnailsListWidget")] public inkWidgetReference ThumbnailsListWidget { get; set; }
		[Ordinal(1)]  [RED("contentWidget")] public inkWidgetReference ContentWidget { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("fileWidgetsData")] public CArray<SDocumentWidgetPackage> FileWidgetsData { get; set; }
		[Ordinal(4)]  [RED("fileThumbnailWidgetsData")] public CArray<SDocumentThumbnailWidgetPackage> FileThumbnailWidgetsData { get; set; }

		public ComputerMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
