using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HotkeyWidgetStatsListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)]  [RED("controller")] public wCHandle<GenericHotkeyController> Controller { get; set; }

		public HotkeyWidgetStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
