using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetHUDEntryVisibility_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("hudEntryName")] public CArray<CName> HudEntryName { get; set; }
		[Ordinal(1)] [RED("usePreset")] public CBool UsePreset { get; set; }
		[Ordinal(2)] [RED("hudVisibilityPreset")] public TweakDBID HudVisibilityPreset { get; set; }
		[Ordinal(3)] [RED("visibility")] public CBool Visibility { get; set; }

		public questSetHUDEntryVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
