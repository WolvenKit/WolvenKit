using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerInt : SettingsSelectorControllerRange
	{
		private CInt32 _newValue;
		private inkWidgetReference _sliderWidget;
		private wCHandle<inkSliderController> _sliderController;

		[Ordinal(19)] 
		[RED("newValue")] 
		public CInt32 NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		[Ordinal(20)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(21)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		public SettingsSelectorControllerInt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
