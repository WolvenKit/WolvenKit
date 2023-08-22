using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModePlayerEntityComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("usedWeaponItemId")] 
		public gameItemID UsedWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("currentWeaponInSlot")] 
		public gameItemID CurrentWeaponInSlot
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(7)] 
		[RED("availableCurrentItemTypesList")] 
		public CArray<CEnum<gamedataItemType>> AvailableCurrentItemTypesList
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(8)] 
		[RED("availableCurrentItemsList")] 
		public CArray<CWeakHandle<gameItemData>> AvailableCurrentItemsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(9)] 
		[RED("swapMeleeWeaponItemId")] 
		public gameItemID SwapMeleeWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(10)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(11)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(12)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(13)] 
		[RED("fakePuppet")] 
		public CWeakHandle<gamePuppet> FakePuppet
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		[Ordinal(14)] 
		[RED("mainPuppet")] 
		public CWeakHandle<PlayerPuppet> MainPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(15)] 
		[RED("currentPuppet")] 
		public CWeakHandle<PlayerPuppet> CurrentPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(16)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(17)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(18)] 
		[RED("itemsLoadingTime")] 
		public CFloat ItemsLoadingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("customizable")] 
		public CBool Customizable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhotoModePlayerEntityComponent()
		{
			UsedWeaponItemId = new gameItemID();
			CurrentWeaponInSlot = new gameItemID();
			AvailableCurrentItemTypesList = new();
			AvailableCurrentItemsList = new();
			SwapMeleeWeaponItemId = new gameItemID();
			SwapHangunWeaponItemId = new gameItemID();
			SwapRifleWeaponItemId = new gameItemID();
			SwapShootgunWeaponItemId = new gameItemID();
			LoadingItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
