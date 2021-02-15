using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionSelectorForAttributeEvent : redEvent
	{
		[Ordinal(0)] [RED("attribute")] public CUInt32 Attribute { get; set; }
		[Ordinal(1)] [RED("values")] public CArray<gameuiPhotoModeOptionSelectorData> Values { get; set; }
		[Ordinal(2)] [RED("startDataValue")] public CInt32 StartDataValue { get; set; }

		public gameuiSetupOptionSelectorForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
