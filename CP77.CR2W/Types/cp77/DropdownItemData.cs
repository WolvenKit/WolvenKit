using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropdownItemData : IScriptable
	{
		[Ordinal(0)] [RED("identifier")] public CVariant Identifier { get; set; }
		[Ordinal(1)] [RED("labelKey")] public CName LabelKey { get; set; }
		[Ordinal(2)] [RED("direction")] public CEnum<DropdownItemDirection> Direction { get; set; }

		public DropdownItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
