using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DropdownItemData : IScriptable
	{
		[Ordinal(0)]  [RED("direction")] public CEnum<DropdownItemDirection> Direction { get; set; }
		[Ordinal(1)]  [RED("identifier")] public CVariant Identifier { get; set; }
		[Ordinal(2)]  [RED("labelKey")] public CName LabelKey { get; set; }

		public DropdownItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
