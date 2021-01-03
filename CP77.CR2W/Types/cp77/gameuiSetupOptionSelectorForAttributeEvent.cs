using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionSelectorForAttributeEvent : redEvent
	{
		[Ordinal(0)]  [RED("attribute")] public CUInt32 Attribute { get; set; }
		[Ordinal(1)]  [RED("startDataValue")] public CInt32 StartDataValue { get; set; }
		[Ordinal(2)]  [RED("values")] public CArray<gameuiPhotoModeOptionSelectorData> Values { get; set; }

		public gameuiSetupOptionSelectorForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
