using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlsActiveEvents : BraindanceControlsTransition
	{
		private CHandle<gameIBlackboard> _braindanceBB;
		private CFloat _blockPerspectiveSwitchTimer;
		private CBool _fxActive;
		private CBool _rewindFxActive;
		private CFloat _holdDuration;
		private CEnum<scnPlaySpeed> _cachedState;
		private CBool _cacheSet;
		private CBool _forwardInput;
		private CBool _backwardInput;
		private CBool _forwardInputLocked;
		private CBool _backwardInputLocked;
		private CEnum<scnPlayDirection> _activeDirection;
		private CBool _rewindRunning;
		private CBool _contextsSetup;
		private CBool _pauseLock;
		private CBool _endRecordingMessageSet;

		[Ordinal(0)] 
		[RED("BraindanceBB")] 
		public CHandle<gameIBlackboard> BraindanceBB
		{
			get => GetProperty(ref _braindanceBB);
			set => SetProperty(ref _braindanceBB, value);
		}

		[Ordinal(1)] 
		[RED("BlockPerspectiveSwitchTimer")] 
		public CFloat BlockPerspectiveSwitchTimer
		{
			get => GetProperty(ref _blockPerspectiveSwitchTimer);
			set => SetProperty(ref _blockPerspectiveSwitchTimer, value);
		}

		[Ordinal(2)] 
		[RED("fxActive")] 
		public CBool FxActive
		{
			get => GetProperty(ref _fxActive);
			set => SetProperty(ref _fxActive, value);
		}

		[Ordinal(3)] 
		[RED("rewindFxActive")] 
		public CBool RewindFxActive
		{
			get => GetProperty(ref _rewindFxActive);
			set => SetProperty(ref _rewindFxActive, value);
		}

		[Ordinal(4)] 
		[RED("holdDuration")] 
		public CFloat HoldDuration
		{
			get => GetProperty(ref _holdDuration);
			set => SetProperty(ref _holdDuration, value);
		}

		[Ordinal(5)] 
		[RED("cachedState")] 
		public CEnum<scnPlaySpeed> CachedState
		{
			get => GetProperty(ref _cachedState);
			set => SetProperty(ref _cachedState, value);
		}

		[Ordinal(6)] 
		[RED("cacheSet")] 
		public CBool CacheSet
		{
			get => GetProperty(ref _cacheSet);
			set => SetProperty(ref _cacheSet, value);
		}

		[Ordinal(7)] 
		[RED("forwardInput")] 
		public CBool ForwardInput
		{
			get => GetProperty(ref _forwardInput);
			set => SetProperty(ref _forwardInput, value);
		}

		[Ordinal(8)] 
		[RED("backwardInput")] 
		public CBool BackwardInput
		{
			get => GetProperty(ref _backwardInput);
			set => SetProperty(ref _backwardInput, value);
		}

		[Ordinal(9)] 
		[RED("forwardInputLocked")] 
		public CBool ForwardInputLocked
		{
			get => GetProperty(ref _forwardInputLocked);
			set => SetProperty(ref _forwardInputLocked, value);
		}

		[Ordinal(10)] 
		[RED("backwardInputLocked")] 
		public CBool BackwardInputLocked
		{
			get => GetProperty(ref _backwardInputLocked);
			set => SetProperty(ref _backwardInputLocked, value);
		}

		[Ordinal(11)] 
		[RED("activeDirection")] 
		public CEnum<scnPlayDirection> ActiveDirection
		{
			get => GetProperty(ref _activeDirection);
			set => SetProperty(ref _activeDirection, value);
		}

		[Ordinal(12)] 
		[RED("rewindRunning")] 
		public CBool RewindRunning
		{
			get => GetProperty(ref _rewindRunning);
			set => SetProperty(ref _rewindRunning, value);
		}

		[Ordinal(13)] 
		[RED("contextsSetup")] 
		public CBool ContextsSetup
		{
			get => GetProperty(ref _contextsSetup);
			set => SetProperty(ref _contextsSetup, value);
		}

		[Ordinal(14)] 
		[RED("pauseLock")] 
		public CBool PauseLock
		{
			get => GetProperty(ref _pauseLock);
			set => SetProperty(ref _pauseLock, value);
		}

		[Ordinal(15)] 
		[RED("endRecordingMessageSet")] 
		public CBool EndRecordingMessageSet
		{
			get => GetProperty(ref _endRecordingMessageSet);
			set => SetProperty(ref _endRecordingMessageSet, value);
		}

		public ControlsActiveEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
