using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadEvents : WeaponEventsTransition
	{
		private CHandle<DefaultTransitionStatListener> _statListener;
		private CHandle<AnimFeature_SelectRandomAnimSync> _randomSync;
		private CHandle<AnimFeature_WeaponReload> _animReloadData;
		private CHandle<AnimFeature_WeaponReloadSpeedData> _animReloadSpeed;
		private CHandle<redCallbackObject> _bbCallbackID;
		private CHandle<gamedataWeaponItem_Record> _weaponRecord;
		private CBool _animReloadDataDirty;
		private CBool _animReloadSpeedDirty;
		private CBool _uninteruptibleSet;
		private CBool _weaponHasAutoLoader;
		private CBool _canReloadWhileSprinting;
		private CBool _magazineEmpty;
		private CBool _lastReloadWasEmpty;

		[Ordinal(3)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(4)] 
		[RED("randomSync")] 
		public CHandle<AnimFeature_SelectRandomAnimSync> RandomSync
		{
			get => GetProperty(ref _randomSync);
			set => SetProperty(ref _randomSync, value);
		}

		[Ordinal(5)] 
		[RED("animReloadData")] 
		public CHandle<AnimFeature_WeaponReload> AnimReloadData
		{
			get => GetProperty(ref _animReloadData);
			set => SetProperty(ref _animReloadData, value);
		}

		[Ordinal(6)] 
		[RED("animReloadSpeed")] 
		public CHandle<AnimFeature_WeaponReloadSpeedData> AnimReloadSpeed
		{
			get => GetProperty(ref _animReloadSpeed);
			set => SetProperty(ref _animReloadSpeed, value);
		}

		[Ordinal(7)] 
		[RED("bbCallbackID")] 
		public CHandle<redCallbackObject> BbCallbackID
		{
			get => GetProperty(ref _bbCallbackID);
			set => SetProperty(ref _bbCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetProperty(ref _weaponRecord);
			set => SetProperty(ref _weaponRecord, value);
		}

		[Ordinal(9)] 
		[RED("animReloadDataDirty")] 
		public CBool AnimReloadDataDirty
		{
			get => GetProperty(ref _animReloadDataDirty);
			set => SetProperty(ref _animReloadDataDirty, value);
		}

		[Ordinal(10)] 
		[RED("animReloadSpeedDirty")] 
		public CBool AnimReloadSpeedDirty
		{
			get => GetProperty(ref _animReloadSpeedDirty);
			set => SetProperty(ref _animReloadSpeedDirty, value);
		}

		[Ordinal(11)] 
		[RED("uninteruptibleSet")] 
		public CBool UninteruptibleSet
		{
			get => GetProperty(ref _uninteruptibleSet);
			set => SetProperty(ref _uninteruptibleSet, value);
		}

		[Ordinal(12)] 
		[RED("weaponHasAutoLoader")] 
		public CBool WeaponHasAutoLoader
		{
			get => GetProperty(ref _weaponHasAutoLoader);
			set => SetProperty(ref _weaponHasAutoLoader, value);
		}

		[Ordinal(13)] 
		[RED("canReloadWhileSprinting")] 
		public CBool CanReloadWhileSprinting
		{
			get => GetProperty(ref _canReloadWhileSprinting);
			set => SetProperty(ref _canReloadWhileSprinting, value);
		}

		[Ordinal(14)] 
		[RED("magazineEmpty")] 
		public CBool MagazineEmpty
		{
			get => GetProperty(ref _magazineEmpty);
			set => SetProperty(ref _magazineEmpty, value);
		}

		[Ordinal(15)] 
		[RED("lastReloadWasEmpty")] 
		public CBool LastReloadWasEmpty
		{
			get => GetProperty(ref _lastReloadWasEmpty);
			set => SetProperty(ref _lastReloadWasEmpty, value);
		}

		public ReloadEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
