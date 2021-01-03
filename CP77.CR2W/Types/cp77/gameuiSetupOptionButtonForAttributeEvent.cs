using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionButtonForAttributeEvent : redEvent
	{
		[Ordinal(0)]  [RED("attribute")] public CUInt32 Attribute { get; set; }
		[Ordinal(1)]  [RED("value")] public CString Value { get; set; }

		public gameuiSetupOptionButtonForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
