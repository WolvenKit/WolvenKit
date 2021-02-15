using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationInfo : IScriptable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("uiSlot")] public CName UiSlot { get; set; }
		[Ordinal(2)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(3)] [RED("defaultIndex")] public CInt32 DefaultIndex { get; set; }
		[Ordinal(4)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(5)] [RED("hidden")] public CBool Hidden { get; set; }
		[Ordinal(6)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(7)] [RED("link")] public CName Link { get; set; }
		[Ordinal(8)] [RED("linkController")] public CBool LinkController { get; set; }
		[Ordinal(9)] [RED("censorFlag")] public CEnum<CensorshipFlags> CensorFlag { get; set; }
		[Ordinal(10)] [RED("censorFlagAction")] public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction { get; set; }
		[Ordinal(11)] [RED("onDeactivateActions")] public CArray<gameuiCharacterCustomizationAction> OnDeactivateActions { get; set; }

		public gameuiCharacterCustomizationInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
