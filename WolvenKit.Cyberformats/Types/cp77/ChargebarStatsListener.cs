using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChargebarStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("controller")] public wCHandle<ChargebarController> Controller { get; set; }

		public ChargebarStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
