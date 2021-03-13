using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UILocRecord : CVariable
	{
		[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(1)] [RED("value")] public CString Value { get; set; }

		public UILocRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
