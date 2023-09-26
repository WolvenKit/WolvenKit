using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>();
			set => SetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>(value);
		}

		[Ordinal(1)] 
		[RED("isFastTravelEnabledOnMap")] 
		public CBool IsFastTravelEnabledOnMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("fastTravelPointsTotal")] 
		public CInt32 FastTravelPointsTotal
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("lastUpdatedAchievementCount")] 
		public CInt32 LastUpdatedAchievementCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("fastTravelLocks")] 
		public CArray<FastTravelSystemLock> FastTravelLocks
		{
			get => GetPropertyValue<CArray<FastTravelSystemLock>>();
			set => SetPropertyValue<CArray<FastTravelSystemLock>>(value);
		}

		[Ordinal(5)] 
		[RED("loadingScreenCallbackID")] 
		public CHandle<redCallbackObject> LoadingScreenCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("requestAutoSafeAfterLoadingScreen")] 
		public CBool RequestAutoSafeAfterLoadingScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("fastTravelSystemRecord")] 
		public CWeakHandle<gamedataFastTravelSystem_Record> FastTravelSystemRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataFastTravelSystem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataFastTravelSystem_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("lockLisenerID")] 
		public CName LockLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("unlockLisenerID")] 
		public CName UnlockLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("removeAllLocksLisenerID")] 
		public CName RemoveAllLocksLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public FastTravelSystem()
		{
			FastTravelNodes = new();
			FastTravelPointsTotal = 159;
			LastUpdatedAchievementCount = -1;
			FastTravelLocks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
