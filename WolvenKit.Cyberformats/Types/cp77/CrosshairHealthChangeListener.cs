using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("parentCrosshair")] public CHandle<gameuiCrosshairBaseGameController> ParentCrosshair { get; set; }

		public CrosshairHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
