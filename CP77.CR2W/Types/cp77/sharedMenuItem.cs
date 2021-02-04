using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sharedMenuItem : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CName Id { get; set; }
		[Ordinal(1)]  [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(2)]  [RED("tooltip")] public CString Tooltip { get; set; }
		[Ordinal(3)]  [RED("subItems")] public CArray<sharedMenuItem> SubItems { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<sharedMenuItemType> Type { get; set; }
		[Ordinal(6)]  [RED("isChecked")] public CBool IsChecked { get; set; }
		[Ordinal(7)]  [RED("checkGroup")] public CString CheckGroup { get; set; }

		public sharedMenuItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
