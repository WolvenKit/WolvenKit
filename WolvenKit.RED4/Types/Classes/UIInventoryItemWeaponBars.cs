using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemWeaponBars : IScriptable
	{
		[Ordinal(0)] 
		[RED("Values")] 
		public CArray<CHandle<UIInventoryItemWeaponBar>> Values
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemWeaponBar>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemWeaponBar>>>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<UIInventoryItemWeaponBarsType> Type
		{
			get => GetPropertyValue<CEnum<UIInventoryItemWeaponBarsType>>();
			set => SetPropertyValue<CEnum<UIInventoryItemWeaponBarsType>>(value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(3)] 
		[RED("comparedBars")] 
		public CHandle<UIInventoryItemWeaponBars> ComparedBars
		{
			get => GetPropertyValue<CHandle<UIInventoryItemWeaponBars>>();
			set => SetPropertyValue<CHandle<UIInventoryItemWeaponBars>>(value);
		}

		public UIInventoryItemWeaponBars()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
