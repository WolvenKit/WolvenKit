using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SBannerWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("content")] public redResourceReferenceScriptToken Content { get; set; }

		public SBannerWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
