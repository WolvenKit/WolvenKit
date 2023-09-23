using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("statComparedContainer")] 
		public inkWidgetReference StatComparedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statComparedValue")] 
		public inkTextWidgetReference StatComparedValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("measurementUnit")] 
		public CEnum<EMeasurementUnit> MeasurementUnit
		{
			get => GetPropertyValue<CEnum<EMeasurementUnit>>();
			set => SetPropertyValue<CEnum<EMeasurementUnit>>(value);
		}

		public ItemTooltipStatController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
