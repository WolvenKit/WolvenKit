using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImageButtonCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("imageAtlasImageID")] public CName ImageAtlasImageID { get; set; }
		[Ordinal(1)]  [RED("additionalText")] public CString AdditionalText { get; set; }

		public ImageButtonCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
