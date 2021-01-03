using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ImageButtonCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("additionalText")] public CString AdditionalText { get; set; }
		[Ordinal(1)]  [RED("imageAtlasImageID")] public CName ImageAtlasImageID { get; set; }

		public ImageButtonCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
