using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProficiencyTabButtonController : TabButtonController
	{
		[Ordinal(0)]  [RED("isToggledState")] public CBool IsToggledState { get; set; }
		[Ordinal(1)]  [RED("proxy")] public CHandle<inkanimProxy> Proxy { get; set; }

		public ProficiencyTabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
