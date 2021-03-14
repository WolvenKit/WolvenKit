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
			get
			{
				if (_braindanceBB == null)
				{
					_braindanceBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "BraindanceBB", cr2w, this);
				}
				return _braindanceBB;
			}
			set
			{
				if (_braindanceBB == value)
				{
					return;
				}
				_braindanceBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BlockPerspectiveSwitchTimer")] 
		public CFloat BlockPerspectiveSwitchTimer
		{
			get
			{
				if (_blockPerspectiveSwitchTimer == null)
				{
					_blockPerspectiveSwitchTimer = (CFloat) CR2WTypeManager.Create("Float", "BlockPerspectiveSwitchTimer", cr2w, this);
				}
				return _blockPerspectiveSwitchTimer;
			}
			set
			{
				if (_blockPerspectiveSwitchTimer == value)
				{
					return;
				}
				_blockPerspectiveSwitchTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fxActive")] 
		public CBool FxActive
		{
			get
			{
				if (_fxActive == null)
				{
					_fxActive = (CBool) CR2WTypeManager.Create("Bool", "fxActive", cr2w, this);
				}
				return _fxActive;
			}
			set
			{
				if (_fxActive == value)
				{
					return;
				}
				_fxActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rewindFxActive")] 
		public CBool RewindFxActive
		{
			get
			{
				if (_rewindFxActive == null)
				{
					_rewindFxActive = (CBool) CR2WTypeManager.Create("Bool", "rewindFxActive", cr2w, this);
				}
				return _rewindFxActive;
			}
			set
			{
				if (_rewindFxActive == value)
				{
					return;
				}
				_rewindFxActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("holdDuration")] 
		public CFloat HoldDuration
		{
			get
			{
				if (_holdDuration == null)
				{
					_holdDuration = (CFloat) CR2WTypeManager.Create("Float", "holdDuration", cr2w, this);
				}
				return _holdDuration;
			}
			set
			{
				if (_holdDuration == value)
				{
					return;
				}
				_holdDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cachedState")] 
		public CEnum<scnPlaySpeed> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<scnPlaySpeed>) CR2WTypeManager.Create("scnPlaySpeed", "cachedState", cr2w, this);
				}
				return _cachedState;
			}
			set
			{
				if (_cachedState == value)
				{
					return;
				}
				_cachedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cacheSet")] 
		public CBool CacheSet
		{
			get
			{
				if (_cacheSet == null)
				{
					_cacheSet = (CBool) CR2WTypeManager.Create("Bool", "cacheSet", cr2w, this);
				}
				return _cacheSet;
			}
			set
			{
				if (_cacheSet == value)
				{
					return;
				}
				_cacheSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("forwardInput")] 
		public CBool ForwardInput
		{
			get
			{
				if (_forwardInput == null)
				{
					_forwardInput = (CBool) CR2WTypeManager.Create("Bool", "forwardInput", cr2w, this);
				}
				return _forwardInput;
			}
			set
			{
				if (_forwardInput == value)
				{
					return;
				}
				_forwardInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("backwardInput")] 
		public CBool BackwardInput
		{
			get
			{
				if (_backwardInput == null)
				{
					_backwardInput = (CBool) CR2WTypeManager.Create("Bool", "backwardInput", cr2w, this);
				}
				return _backwardInput;
			}
			set
			{
				if (_backwardInput == value)
				{
					return;
				}
				_backwardInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("forwardInputLocked")] 
		public CBool ForwardInputLocked
		{
			get
			{
				if (_forwardInputLocked == null)
				{
					_forwardInputLocked = (CBool) CR2WTypeManager.Create("Bool", "forwardInputLocked", cr2w, this);
				}
				return _forwardInputLocked;
			}
			set
			{
				if (_forwardInputLocked == value)
				{
					return;
				}
				_forwardInputLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("backwardInputLocked")] 
		public CBool BackwardInputLocked
		{
			get
			{
				if (_backwardInputLocked == null)
				{
					_backwardInputLocked = (CBool) CR2WTypeManager.Create("Bool", "backwardInputLocked", cr2w, this);
				}
				return _backwardInputLocked;
			}
			set
			{
				if (_backwardInputLocked == value)
				{
					return;
				}
				_backwardInputLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("activeDirection")] 
		public CEnum<scnPlayDirection> ActiveDirection
		{
			get
			{
				if (_activeDirection == null)
				{
					_activeDirection = (CEnum<scnPlayDirection>) CR2WTypeManager.Create("scnPlayDirection", "activeDirection", cr2w, this);
				}
				return _activeDirection;
			}
			set
			{
				if (_activeDirection == value)
				{
					return;
				}
				_activeDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rewindRunning")] 
		public CBool RewindRunning
		{
			get
			{
				if (_rewindRunning == null)
				{
					_rewindRunning = (CBool) CR2WTypeManager.Create("Bool", "rewindRunning", cr2w, this);
				}
				return _rewindRunning;
			}
			set
			{
				if (_rewindRunning == value)
				{
					return;
				}
				_rewindRunning = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("contextsSetup")] 
		public CBool ContextsSetup
		{
			get
			{
				if (_contextsSetup == null)
				{
					_contextsSetup = (CBool) CR2WTypeManager.Create("Bool", "contextsSetup", cr2w, this);
				}
				return _contextsSetup;
			}
			set
			{
				if (_contextsSetup == value)
				{
					return;
				}
				_contextsSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("pauseLock")] 
		public CBool PauseLock
		{
			get
			{
				if (_pauseLock == null)
				{
					_pauseLock = (CBool) CR2WTypeManager.Create("Bool", "pauseLock", cr2w, this);
				}
				return _pauseLock;
			}
			set
			{
				if (_pauseLock == value)
				{
					return;
				}
				_pauseLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("endRecordingMessageSet")] 
		public CBool EndRecordingMessageSet
		{
			get
			{
				if (_endRecordingMessageSet == null)
				{
					_endRecordingMessageSet = (CBool) CR2WTypeManager.Create("Bool", "endRecordingMessageSet", cr2w, this);
				}
				return _endRecordingMessageSet;
			}
			set
			{
				if (_endRecordingMessageSet == value)
				{
					return;
				}
				_endRecordingMessageSet = value;
				PropertySet(this);
			}
		}

		public ControlsActiveEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
