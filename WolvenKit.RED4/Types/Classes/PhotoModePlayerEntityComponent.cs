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
		[RED("swapMeleeWeaponItemId")] 
		public gameItemID SwapMeleeWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(9)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(10)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(11)] 
		[RED("fakePuppet")] 
		public CWeakHandle<gamePuppet> FakePuppet
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		[Ordinal(12)] 
		[RED("mainPuppet")] 
		public CWeakHandle<PlayerPuppet> MainPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(13)] 
		[RED("currentPuppet")] 
		public CWeakHandle<PlayerPuppet> CurrentPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(14)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(15)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(16)] 
		[RED("loadingVisualItems")] 
		public CArray<gameItemID> LoadingVisualItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(17)] 
		[RED("itemsLoadingTime")] 
		public CFloat ItemsLoadingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("customizable")] 
		public CBool Customizable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("holsteredArmsShouldBeVisible")] 
		public CBool HolsteredArmsShouldBeVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("holsteredArmsBeingSpawned")] 
		public CBool HolsteredArmsBeingSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("holsteredArmsVisible")] 
		public CBool HolsteredArmsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("holsteredArmsItem")] 
		public gameItemID HolsteredArmsItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(24)] 
		[RED("cyberwareArmsBeingSpawned")] 
		public CBool CyberwareArmsBeingSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("cyberwareArmsVisible")] 
		public CBool CyberwareArmsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("cyberwareArmsItem")] 
		public gameItemID CyberwareArmsItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public PhotoModePlayerEntityComponent()
		{
			UsedWeaponItemId = new gameItemID();
			CurrentWeaponInSlot = new gameItemID();
			SwapMeleeWeaponItemId = new gameItemID();
			SwapHangunWeaponItemId = new gameItemID();
			SwapRifleWeaponItemId = new gameItemID();
			SwapShootgunWeaponItemId = new gameItemID();
			LoadingItems = new();
			LoadingVisualItems = new();
			HolsteredArmsItem = new gameItemID();
			CyberwareArmsItem = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
