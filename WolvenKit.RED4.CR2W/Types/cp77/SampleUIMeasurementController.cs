using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUIMeasurementController : inkWidgetLogicController
	{
		private CFloat _value;
		private CEnum<EMeasurementUnit> _unit;
		private inkTextWidgetReference _valueText;
		private inkTextWidgetReference _unitText;
		private inkWidgetReference _valueIncreaseButton;
		private inkWidgetReference _valueDecreaseButton;

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(3)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetProperty(ref _valueText);
			set => SetProperty(ref _valueText, value);
		}

		[Ordinal(4)] 
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get => GetProperty(ref _unitText);
			set => SetProperty(ref _unitText, value);
		}

		[Ordinal(5)] 
		[RED("valueIncreaseButton")] 
		public inkWidgetReference ValueIncreaseButton
		{
			get => GetProperty(ref _valueIncreaseButton);
			set => SetProperty(ref _valueIncreaseButton, value);
		}

		[Ordinal(6)] 
		[RED("valueDecreaseButton")] 
		public inkWidgetReference ValueDecreaseButton
		{
			get => GetProperty(ref _valueDecreaseButton);
			set => SetProperty(ref _valueDecreaseButton, value);
		}

		public SampleUIMeasurementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
