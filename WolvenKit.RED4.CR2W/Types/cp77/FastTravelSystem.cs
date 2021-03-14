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
			get
			{
				if (_fastTravelNodes == null)
				{
					_fastTravelNodes = (CArray<CHandle<gameFastTravelPointData>>) CR2WTypeManager.Create("array:handle:gameFastTravelPointData", "fastTravelNodes", cr2w, this);
				}
				return _fastTravelNodes;
			}
			set
			{
				if (_fastTravelNodes == value)
				{
					return;
				}
				_fastTravelNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isFastTravelEnabledOnMap")] 
		public CBool IsFastTravelEnabledOnMap
		{
			get
			{
				if (_isFastTravelEnabledOnMap == null)
				{
					_isFastTravelEnabledOnMap = (CBool) CR2WTypeManager.Create("Bool", "isFastTravelEnabledOnMap", cr2w, this);
				}
				return _isFastTravelEnabledOnMap;
			}
			set
			{
				if (_isFastTravelEnabledOnMap == value)
				{
					return;
				}
				_isFastTravelEnabledOnMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fastTravelPointsTotal")] 
		public CInt32 FastTravelPointsTotal
		{
			get
			{
				if (_fastTravelPointsTotal == null)
				{
					_fastTravelPointsTotal = (CInt32) CR2WTypeManager.Create("Int32", "fastTravelPointsTotal", cr2w, this);
				}
				return _fastTravelPointsTotal;
			}
			set
			{
				if (_fastTravelPointsTotal == value)
				{
					return;
				}
				_fastTravelPointsTotal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fastTravelLocks")] 
		public CArray<FastTravelSystemLock> FastTravelLocks
		{
			get
			{
				if (_fastTravelLocks == null)
				{
					_fastTravelLocks = (CArray<FastTravelSystemLock>) CR2WTypeManager.Create("array:FastTravelSystemLock", "fastTravelLocks", cr2w, this);
				}
				return _fastTravelLocks;
			}
			set
			{
				if (_fastTravelLocks == value)
				{
					return;
				}
				_fastTravelLocks = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loadingScreenCallbackID")] 
		public CUInt32 LoadingScreenCallbackID
		{
			get
			{
				if (_loadingScreenCallbackID == null)
				{
					_loadingScreenCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "loadingScreenCallbackID", cr2w, this);
				}
				return _loadingScreenCallbackID;
			}
			set
			{
				if (_loadingScreenCallbackID == value)
				{
					return;
				}
				_loadingScreenCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("requestAutoSafeAfterLoadingScreen")] 
		public CBool RequestAutoSafeAfterLoadingScreen
		{
			get
			{
				if (_requestAutoSafeAfterLoadingScreen == null)
				{
					_requestAutoSafeAfterLoadingScreen = (CBool) CR2WTypeManager.Create("Bool", "requestAutoSafeAfterLoadingScreen", cr2w, this);
				}
				return _requestAutoSafeAfterLoadingScreen;
			}
			set
			{
				if (_requestAutoSafeAfterLoadingScreen == value)
				{
					return;
				}
				_requestAutoSafeAfterLoadingScreen = value;
				PropertySet(this);
			}
		}

		public FastTravelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
