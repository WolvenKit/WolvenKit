using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HotkeyWidgetStatsListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)]  [RED("controller")] public wCHandle<GenericHotkeyController> Controller { get; set; }

		public HotkeyWidgetStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
