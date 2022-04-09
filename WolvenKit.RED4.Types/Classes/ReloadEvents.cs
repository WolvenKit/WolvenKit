using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReloadEvents : WeaponEventsTransition
	{
		[Ordinal(3)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatListener>>(value);
		}

		[Ordinal(4)] 
		[RED("randomSync")] 
		public CHandle<AnimFeature_SelectRandomAnimSync> RandomSync
		{
			get => GetPropertyValue<CHandle<AnimFeature_SelectRandomAnimSync>>();
			set => SetPropertyValue<CHandle<AnimFeature_SelectRandomAnimSync>>(value);
		}

		[Ordinal(5)] 
		[RED("animReloadData")] 
		public CHandle<AnimFeature_WeaponReload> AnimReloadData
		{
			get => GetPropertyValue<CHandle<AnimFeature_WeaponReload>>();
			set => SetPropertyValue<CHandle<AnimFeature_WeaponReload>>(value);
		}

		[Ordinal(6)] 
		[RED("animReloadSpeed")] 
		public CHandle<AnimFeature_WeaponReloadSpeedData> AnimReloadSpeed
		{
			get => GetPropertyValue<CHandle<AnimFeature_WeaponReloadSpeedData>>();
			set => SetPropertyValue<CHandle<AnimFeature_WeaponReloadSpeedData>>(value);
		}

		[Ordinal(7)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("animReloadDataDirty")] 
		public CBool AnimReloadDataDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("animReloadSpeedDirty")] 
		public CBool AnimReloadSpeedDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("uninteruptibleSet")] 
		public CBool UninteruptibleSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("weaponHasAutoLoader")] 
		public CBool WeaponHasAutoLoader
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("canReloadWhileSprinting")] 
		public CBool CanReloadWhileSprinting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("lastReloadWasEmpty")] 
		public CBool LastReloadWasEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ReloadEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
