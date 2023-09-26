using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargeIndicatorGameController : ChargedHotkeyItemBaseController
	{
		[Ordinal(42)] 
		[RED("itemIcon")] 
		public inkImageWidgetReference ItemIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("type")] 
		public CEnum<ChargeIndicatorWidgetType> Type
		{
			get => GetPropertyValue<CEnum<ChargeIndicatorWidgetType>>();
			set => SetPropertyValue<CEnum<ChargeIndicatorWidgetType>>(value);
		}

		[Ordinal(44)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(45)] 
		[RED("iconName")] 
		public CString IconName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("itemType")] 
		public CName ItemType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("eqArea")] 
		public CEnum<gamedataEquipmentArea> EqArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(48)] 
		[RED("OnEquipmentChangedIDBBID")] 
		public CHandle<redCallbackObject> OnEquipmentChangedIDBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("c_fullChargeOpacity")] 
		public CFloat C_fullChargeOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ChargeIndicatorGameController()
		{
			ItemIcon = new inkImageWidgetReference();
			C_fullChargeOpacity = 0.400000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
