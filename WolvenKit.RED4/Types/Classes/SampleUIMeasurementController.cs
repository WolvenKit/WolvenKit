using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleUIMeasurementController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get => GetPropertyValue<CEnum<EMeasurementUnit>>();
			set => SetPropertyValue<CEnum<EMeasurementUnit>>(value);
		}

		[Ordinal(3)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("valueIncreaseButton")] 
		public inkWidgetReference ValueIncreaseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("valueDecreaseButton")] 
		public inkWidgetReference ValueDecreaseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SampleUIMeasurementController()
		{
			ValueText = new inkTextWidgetReference();
			UnitText = new inkTextWidgetReference();
			ValueIncreaseButton = new inkWidgetReference();
			ValueDecreaseButton = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
