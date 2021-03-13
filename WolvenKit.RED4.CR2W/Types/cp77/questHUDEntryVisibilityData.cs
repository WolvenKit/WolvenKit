using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityData : CVariable
	{
		[Ordinal(0)] [RED("hudEntryName")] public CName HudEntryName { get; set; }
		[Ordinal(1)] [RED("visibility")] public CEnum<worlduiEntryVisibility> Visibility { get; set; }

		public questHUDEntryVisibilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
