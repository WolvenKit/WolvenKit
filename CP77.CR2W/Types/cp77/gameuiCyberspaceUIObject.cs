using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberspaceUIObject : gameObject
	{
		[Ordinal(0)]  [RED("caption")] public CString Caption { get; set; }
		[Ordinal(1)]  [RED("mappinType")] public CEnum<gameuiCyberspaceElementType> MappinType { get; set; }
		[Ordinal(2)]  [RED("slotName")] public CName SlotName { get; set; }

		public gameuiCyberspaceUIObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
