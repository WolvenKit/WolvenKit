using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerFloat : SettingsSelectorControllerRange
	{
		private CFloat _newValue;
		private inkWidgetReference _sliderWidget;
		private wCHandle<inkSliderController> _sliderController;

		[Ordinal(19)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get
			{
				if (_newValue == null)
				{
					_newValue = (CFloat) CR2WTypeManager.Create("Float", "newValue", cr2w, this);
				}
				return _newValue;
			}
			set
			{
				if (_newValue == value)
				{
					return;
				}
				_newValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get
			{
				if (_sliderWidget == null)
				{
					_sliderWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sliderWidget", cr2w, this);
				}
				return _sliderWidget;
			}
			set
			{
				if (_sliderWidget == value)
				{
					return;
				}
				_sliderWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get
			{
				if (_sliderController == null)
				{
					_sliderController = (wCHandle<inkSliderController>) CR2WTypeManager.Create("whandle:inkSliderController", "sliderController", cr2w, this);
				}
				return _sliderController;
			}
			set
			{
				if (_sliderController == value)
				{
					return;
				}
				_sliderController = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
