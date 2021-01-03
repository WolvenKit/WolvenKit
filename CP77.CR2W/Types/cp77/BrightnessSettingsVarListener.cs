using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)]  [RED("ctrl")] public wCHandle<BrightnessSettingsGameController> Ctrl { get; set; }

		public BrightnessSettingsVarListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
