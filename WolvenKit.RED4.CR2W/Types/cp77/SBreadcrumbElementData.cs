using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBreadcrumbElementData : CVariable
	{
		[Ordinal(0)] [RED("elementName")] public CString ElementName { get; set; }
		[Ordinal(1)] [RED("elementID")] public CInt32 ElementID { get; set; }

		public SBreadcrumbElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
