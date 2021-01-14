using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuData : CVariable
	{
		[Ordinal(0)]  [RED("attrFlag")] public CBool AttrFlag { get; set; }
		[Ordinal(1)]  [RED("attrText")] public CInt32 AttrText { get; set; }
		[Ordinal(2)]  [RED("disabled")] public CBool Disabled { get; set; }
		[Ordinal(3)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(4)]  [RED("fullscreenName")] public CName FullscreenName { get; set; }
		[Ordinal(5)]  [RED("icon")] public CName Icon { get; set; }
		[Ordinal(6)]  [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(7)]  [RED("label")] public CString Label { get; set; }
		[Ordinal(8)]  [RED("overrideDefaultUserData")] public CBool OverrideDefaultUserData { get; set; }
		[Ordinal(9)]  [RED("overrideSubMenuUserData")] public CBool OverrideSubMenuUserData { get; set; }
		[Ordinal(10)]  [RED("parentIdentifier")] public CInt32 ParentIdentifier { get; set; }
		[Ordinal(11)]  [RED("perkFlag")] public CBool PerkFlag { get; set; }
		[Ordinal(12)]  [RED("perkText")] public CInt32 PerkText { get; set; }
		[Ordinal(13)]  [RED("subMenus")] public CArray<MenuData> SubMenus { get; set; }
		[Ordinal(14)]  [RED("userData")] public CHandle<IScriptable> UserData { get; set; }

		public MenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
