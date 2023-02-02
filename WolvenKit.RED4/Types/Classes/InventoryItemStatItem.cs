using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemStatItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("differenceBarRef")] 
		public inkWidgetReference DifferenceBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("diffrenceArrowIndicatorRef")] 
		public inkWidgetReference DiffrenceArrowIndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("differenceBar")] 
		public CWeakHandle<StatisticDifferenceBarController> DifferenceBar
		{
			get => GetPropertyValue<CWeakHandle<StatisticDifferenceBarController>>();
			set => SetPropertyValue<CWeakHandle<StatisticDifferenceBarController>>(value);
		}

		[Ordinal(7)] 
		[RED("negativeState")] 
		public CName NegativeState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("positiveState")] 
		public CName PositiveState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public InventoryItemStatItem()
		{
			LabelText = new();
			ValueText = new();
			DifferenceBarRef = new();
			DiffrenceArrowIndicatorRef = new();
			NegativeState = "worse";
			PositiveState = "better";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
