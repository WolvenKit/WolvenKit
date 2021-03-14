using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyTabButtonController : TabButtonController
	{
		[Ordinal(18)] [RED("proxy")] public CHandle<inkanimProxy> Proxy { get; set; }
		[Ordinal(19)] [RED("isToggledState")] public CBool IsToggledState { get; set; }

		public ProficiencyTabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
