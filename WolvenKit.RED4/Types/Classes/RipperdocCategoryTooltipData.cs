using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocCategoryTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<gamedataEquipmentArea> Category
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("ownedItems")] 
		public CInt32 OwnedItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("availableItems")] 
		public CInt32 AvailableItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("screenType")] 
		public CEnum<CyberwareScreenType> ScreenType
		{
			get => GetPropertyValue<CEnum<CyberwareScreenType>>();
			set => SetPropertyValue<CEnum<CyberwareScreenType>>(value);
		}

		public RipperdocCategoryTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
