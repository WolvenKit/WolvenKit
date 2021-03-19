using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystem : gameScriptableSystem
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;
		private CBool _isFastTravelEnabledOnMap;
		private CInt32 _fastTravelPointsTotal;
		private CArray<FastTravelSystemLock> _fastTravelLocks;
		private CUInt32 _loadingScreenCallbackID;
		private CBool _requestAutoSafeAfterLoadingScreen;

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
		[RED("fastTravelLocks")] 
		public CArray<FastTravelSystemLock> FastTravelLocks
		{
			get => GetProperty(ref _fastTravelLocks);
			set => SetProperty(ref _fastTravelLocks, value);
		}

		[Ordinal(4)] 
		[RED("loadingScreenCallbackID")] 
		public CUInt32 LoadingScreenCallbackID
		{
			get => GetProperty(ref _loadingScreenCallbackID);
			set => SetProperty(ref _loadingScreenCallbackID, value);
		}

		[Ordinal(5)] 
		[RED("requestAutoSafeAfterLoadingScreen")] 
		public CBool RequestAutoSafeAfterLoadingScreen
		{
			get => GetProperty(ref _requestAutoSafeAfterLoadingScreen);
			set => SetProperty(ref _requestAutoSafeAfterLoadingScreen, value);
		}

		public FastTravelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
