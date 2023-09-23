using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlotUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<UIInventoryItem> Item
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(3)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("visibleWhenLocked")] 
		public CBool VisibleWhenLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetPropertyValue<CEnum<CyberwareScreenType>>();
			set => SetPropertyValue<CEnum<CyberwareScreenType>>(value);
		}

		[Ordinal(6)] 
		[RED("isPerkRequired")] 
		public CBool IsPerkRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("canUpgrade")] 
		public CBool CanUpgrade
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("upgradeItem")] 
		public CWeakHandle<gamedataItem_Record> UpgradeItem
		{
			get => GetPropertyValue<CWeakHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("upgradeItemQuality")] 
		public CEnum<gamedataQuality> UpgradeItemQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		public SlotUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
