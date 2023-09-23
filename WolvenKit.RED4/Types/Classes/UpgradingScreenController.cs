using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpgradingScreenController : CraftingMainLogicController
	{
		[Ordinal(50)] 
		[RED("itemNameUpgrade")] 
		public inkTextWidgetReference ItemNameUpgrade
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("arrowComparison")] 
		public inkWidgetReference ArrowComparison
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("itemTooltipControllerLeft")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipControllerLeft
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(53)] 
		[RED("itemTooltipControllerRight")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipControllerRight
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(54)] 
		[RED("tooltipDataLeft")] 
		public CHandle<MinimalItemTooltipData> TooltipDataLeft
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipData>>(value);
		}

		[Ordinal(55)] 
		[RED("tooltipDataRight")] 
		public CHandle<MinimalItemTooltipData> TooltipDataRight
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipData>>(value);
		}

		[Ordinal(56)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(57)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(58)] 
		[RED("DELAYED_TOOLTIP_RIGHT")] 
		public CFloat DELAYED_TOOLTIP_RIGHT
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UpgradingScreenController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
