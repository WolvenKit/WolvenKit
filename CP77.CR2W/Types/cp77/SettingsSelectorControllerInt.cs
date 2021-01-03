using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerInt : SettingsSelectorControllerRange
	{
		[Ordinal(0)]  [RED("newValue")] public CInt32 NewValue { get; set; }
		[Ordinal(1)]  [RED("sliderController")] public wCHandle<inkSliderController> SliderController { get; set; }
		[Ordinal(2)]  [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }

		public SettingsSelectorControllerInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
