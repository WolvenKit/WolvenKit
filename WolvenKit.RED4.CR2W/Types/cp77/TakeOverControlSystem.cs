using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakeOverControlSystem : gameScriptableSystem
	{
		private wCHandle<gameObject> _controlledObject;
		private CBool _isInputRegistered;
		private CBool _isInputLockedFromQuest;
		private CBool _isChainForcedFromQuest;
		private CBool _isActionButtonLocked;
		private CBool _isDeviceChainCreationLocked;
		private CArray<CName> _chainLockSources;
		private gameDelayID _tCDUpdateDelayID;
		private CFloat _tCSupdateRate;
		private CFloat _lastInputSimTime;

		[Ordinal(0)] 
		[RED("controlledObject")] 
		public wCHandle<gameObject> ControlledObject
		{
			get => GetProperty(ref _controlledObject);
			set => SetProperty(ref _controlledObject, value);
		}

		[Ordinal(1)] 
		[RED("isInputRegistered")] 
		public CBool IsInputRegistered
		{
			get => GetProperty(ref _isInputRegistered);
			set => SetProperty(ref _isInputRegistered, value);
		}

		[Ordinal(2)] 
		[RED("isInputLockedFromQuest")] 
		public CBool IsInputLockedFromQuest
		{
			get => GetProperty(ref _isInputLockedFromQuest);
			set => SetProperty(ref _isInputLockedFromQuest, value);
		}

		[Ordinal(3)] 
		[RED("isChainForcedFromQuest")] 
		public CBool IsChainForcedFromQuest
		{
			get => GetProperty(ref _isChainForcedFromQuest);
			set => SetProperty(ref _isChainForcedFromQuest, value);
		}

		[Ordinal(4)] 
		[RED("isActionButtonLocked")] 
		public CBool IsActionButtonLocked
		{
			get => GetProperty(ref _isActionButtonLocked);
			set => SetProperty(ref _isActionButtonLocked, value);
		}

		[Ordinal(5)] 
		[RED("isDeviceChainCreationLocked")] 
		public CBool IsDeviceChainCreationLocked
		{
			get => GetProperty(ref _isDeviceChainCreationLocked);
			set => SetProperty(ref _isDeviceChainCreationLocked, value);
		}

		[Ordinal(6)] 
		[RED("chainLockSources")] 
		public CArray<CName> ChainLockSources
		{
			get => GetProperty(ref _chainLockSources);
			set => SetProperty(ref _chainLockSources, value);
		}

		[Ordinal(7)] 
		[RED("TCDUpdateDelayID")] 
		public gameDelayID TCDUpdateDelayID
		{
			get => GetProperty(ref _tCDUpdateDelayID);
			set => SetProperty(ref _tCDUpdateDelayID, value);
		}

		[Ordinal(8)] 
		[RED("TCSupdateRate")] 
		public CFloat TCSupdateRate
		{
			get => GetProperty(ref _tCSupdateRate);
			set => SetProperty(ref _tCSupdateRate, value);
		}

		[Ordinal(9)] 
		[RED("lastInputSimTime")] 
		public CFloat LastInputSimTime
		{
			get => GetProperty(ref _lastInputSimTime);
			set => SetProperty(ref _lastInputSimTime, value);
		}

		public TakeOverControlSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
