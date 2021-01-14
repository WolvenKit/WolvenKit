using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetHUDEntryVisibility_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("hudEntryName")] public CArray<CName> HudEntryName { get; set; }
		[Ordinal(1)]  [RED("hudVisibilityPreset")] public TweakDBID HudVisibilityPreset { get; set; }
		[Ordinal(2)]  [RED("usePreset")] public CBool UsePreset { get; set; }
		[Ordinal(3)]  [RED("visibility")] public CBool Visibility { get; set; }

		public questSetHUDEntryVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
