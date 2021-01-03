using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerList : SettingsSelectorControllerRange
	{
		[Ordinal(0)]  [RED("dotsContainer")] public inkHorizontalPanelWidgetReference DotsContainer { get; set; }

		public SettingsSelectorControllerList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
