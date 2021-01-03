using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TogglePersonalLink : ActionBool
	{
		[Ordinal(0)]  [RED("cachedStatus")] public CEnum<EPersonalLinkConnectionStatus> CachedStatus { get; set; }
		[Ordinal(1)]  [RED("shouldSkipMiniGame")] public CBool ShouldSkipMiniGame { get; set; }

		public TogglePersonalLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
