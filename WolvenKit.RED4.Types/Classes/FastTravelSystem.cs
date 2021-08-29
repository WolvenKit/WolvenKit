using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelSystem : gameScriptableSystem
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;
		private CBool _isFastTravelEnabledOnMap;
		private CInt32 _fastTravelPointsTotal;
		private CInt32 _lastUpdatedAchievementCount;
		private CArray<FastTravelSystemLock> _fastTravelLocks;
		private CHandle<redCallbackObject> _loadingScreenCallbackID;
		private CBool _requestAutoSafeAfterLoadingScreen;
		private CName _lockLisenerID;
		private CName _unlockLisenerID;
		private CName _removeAllLocksLisenerID;

		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetProperty(ref _fastTravelNodes);
			set => SetProperty(ref _fastTravelNodes, value);
		}

		[Ordinal(1)] 
		[RED("isFastTravelEnabledOnMap")] 
		public CBool IsFastTravelEnabledOnMap
		{
			get => GetProperty(ref _isFastTravelEnabledOnMap);
			set => SetProperty(ref _isFastTravelEnabledOnMap, value);
		}

		[Ordinal(2)] 
		[RED("fastTravelPointsTotal")] 
		public CInt32 FastTravelPointsTotal
		{
			get => GetProperty(ref _fastTravelPointsTotal);
			set => SetProperty(ref _fastTravelPointsTotal, value);
		}

		[Ordinal(3)] 
		[RED("lastUpdatedAchievementCount")] 
		public CInt32 LastUpdatedAchievementCount
		{
			get => GetProperty(ref _lastUpdatedAchievementCount);
			set => SetProperty(ref _lastUpdatedAchievementCount, value);
		}

		[Ordinal(4)] 
		[RED("fastTravelLocks")] 
		public CArray<FastTravelSystemLock> FastTravelLocks
		{
			get => GetProperty(ref _fastTravelLocks);
			set => SetProperty(ref _fastTravelLocks, value);
		}

		[Ordinal(5)] 
		[RED("loadingScreenCallbackID")] 
		public CHandle<redCallbackObject> LoadingScreenCallbackID
		{
			get => GetProperty(ref _loadingScreenCallbackID);
			set => SetProperty(ref _loadingScreenCallbackID, value);
		}

		[Ordinal(6)] 
		[RED("requestAutoSafeAfterLoadingScreen")] 
		public CBool RequestAutoSafeAfterLoadingScreen
		{
			get => GetProperty(ref _requestAutoSafeAfterLoadingScreen);
			set => SetProperty(ref _requestAutoSafeAfterLoadingScreen, value);
		}

		[Ordinal(7)] 
		[RED("lockLisenerID")] 
		public CName LockLisenerID
		{
			get => GetProperty(ref _lockLisenerID);
			set => SetProperty(ref _lockLisenerID, value);
		}

		[Ordinal(8)] 
		[RED("unlockLisenerID")] 
		public CName UnlockLisenerID
		{
			get => GetProperty(ref _unlockLisenerID);
			set => SetProperty(ref _unlockLisenerID, value);
		}

		[Ordinal(9)] 
		[RED("removeAllLocksLisenerID")] 
		public CName RemoveAllLocksLisenerID
		{
			get => GetProperty(ref _removeAllLocksLisenerID);
			set => SetProperty(ref _removeAllLocksLisenerID, value);
		}
	}
}
