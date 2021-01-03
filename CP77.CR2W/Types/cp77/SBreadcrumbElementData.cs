using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SBreadcrumbElementData : CVariable
	{
		[Ordinal(0)]  [RED("elementID")] public CInt32 ElementID { get; set; }
		[Ordinal(1)]  [RED("elementName")] public CString ElementName { get; set; }

		public SBreadcrumbElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
