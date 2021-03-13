using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerInt : SettingsSelectorControllerRange
	{
		[Ordinal(19)] [RED("newValue")] public CInt32 NewValue { get; set; }
		[Ordinal(20)] [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }
		[Ordinal(21)] [RED("sliderController")] public wCHandle<inkSliderController> SliderController { get; set; }

		public SettingsSelectorControllerInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
