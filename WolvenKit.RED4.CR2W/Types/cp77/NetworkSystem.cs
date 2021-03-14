using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkSystem : gameScriptableSystem
	{
		private CArray<SNetworkLinkData> _networkLinks;
		private CArray<entEntityID> _networkRevealTargets;
		private CBool _sessionStarted;
		private CUInt32 _visionModeChangedCallback;
		private CUInt32 _focusModeToggleCallback;
		private CUInt32 _playerSpawnCallback;
		private CUInt32 _currentPlayerTargetCallbackID;
		private entEntityID _lastTargetSlaveID;
		private entEntityID _lastTargetMasterID;
		private gameDelayID _unregisterLinksRequestDelay;
		private CBool _focusModeActive;
		private gameFxResource _lastBeamResource;
		private CHandle<gameEffectInstance> _pingNetworkEffect;
		private CHandle<PingCachedData> _pingCachedData;
		private entEntityID _lastPingSourceID;
		private CArray<CHandle<PingCachedData>> _activePings;
		private CInt32 _pingLinksCounter;
		private TweakDBID _networkPresetTBDID;
		private wCHandle<gamedataNetworkPingingParameteres_Record> _networkPresetRecord;
		private CArray<gamePersistentID> _backdoors;
		private CInt32 _revealedBackdoorsCount;
		private gameFxResource _debugCashedPingFxResource;
		private CInt32 _debugQueryNumber;

		[Ordinal(0)] 
		[RED("networkLinks")] 
		public CArray<SNetworkLinkData> NetworkLinks
		{
			get
			{
				if (_networkLinks == null)
				{
					_networkLinks = (CArray<SNetworkLinkData>) CR2WTypeManager.Create("array:SNetworkLinkData", "networkLinks", cr2w, this);
				}
				return _networkLinks;
			}
			set
			{
				if (_networkLinks == value)
				{
					return;
				}
				_networkLinks = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("networkRevealTargets")] 
		public CArray<entEntityID> NetworkRevealTargets
		{
			get
			{
				if (_networkRevealTargets == null)
				{
					_networkRevealTargets = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "networkRevealTargets", cr2w, this);
				}
				return _networkRevealTargets;
			}
			set
			{
				if (_networkRevealTargets == value)
				{
					return;
				}
				_networkRevealTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sessionStarted")] 
		public CBool SessionStarted
		{
			get
			{
				if (_sessionStarted == null)
				{
					_sessionStarted = (CBool) CR2WTypeManager.Create("Bool", "sessionStarted", cr2w, this);
				}
				return _sessionStarted;
			}
			set
			{
				if (_sessionStarted == value)
				{
					return;
				}
				_sessionStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visionModeChangedCallback")] 
		public CUInt32 VisionModeChangedCallback
		{
			get
			{
				if (_visionModeChangedCallback == null)
				{
					_visionModeChangedCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "visionModeChangedCallback", cr2w, this);
				}
				return _visionModeChangedCallback;
			}
			set
			{
				if (_visionModeChangedCallback == value)
				{
					return;
				}
				_visionModeChangedCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("focusModeToggleCallback")] 
		public CUInt32 FocusModeToggleCallback
		{
			get
			{
				if (_focusModeToggleCallback == null)
				{
					_focusModeToggleCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "focusModeToggleCallback", cr2w, this);
				}
				return _focusModeToggleCallback;
			}
			set
			{
				if (_focusModeToggleCallback == value)
				{
					return;
				}
				_focusModeToggleCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playerSpawnCallback")] 
		public CUInt32 PlayerSpawnCallback
		{
			get
			{
				if (_playerSpawnCallback == null)
				{
					_playerSpawnCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "playerSpawnCallback", cr2w, this);
				}
				return _playerSpawnCallback;
			}
			set
			{
				if (_playerSpawnCallback == value)
				{
					return;
				}
				_playerSpawnCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CUInt32 CurrentPlayerTargetCallbackID
		{
			get
			{
				if (_currentPlayerTargetCallbackID == null)
				{
					_currentPlayerTargetCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentPlayerTargetCallbackID", cr2w, this);
				}
				return _currentPlayerTargetCallbackID;
			}
			set
			{
				if (_currentPlayerTargetCallbackID == value)
				{
					return;
				}
				_currentPlayerTargetCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lastTargetSlaveID")] 
		public entEntityID LastTargetSlaveID
		{
			get
			{
				if (_lastTargetSlaveID == null)
				{
					_lastTargetSlaveID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastTargetSlaveID", cr2w, this);
				}
				return _lastTargetSlaveID;
			}
			set
			{
				if (_lastTargetSlaveID == value)
				{
					return;
				}
				_lastTargetSlaveID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lastTargetMasterID")] 
		public entEntityID LastTargetMasterID
		{
			get
			{
				if (_lastTargetMasterID == null)
				{
					_lastTargetMasterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastTargetMasterID", cr2w, this);
				}
				return _lastTargetMasterID;
			}
			set
			{
				if (_lastTargetMasterID == value)
				{
					return;
				}
				_lastTargetMasterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("unregisterLinksRequestDelay")] 
		public gameDelayID UnregisterLinksRequestDelay
		{
			get
			{
				if (_unregisterLinksRequestDelay == null)
				{
					_unregisterLinksRequestDelay = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "unregisterLinksRequestDelay", cr2w, this);
				}
				return _unregisterLinksRequestDelay;
			}
			set
			{
				if (_unregisterLinksRequestDelay == value)
				{
					return;
				}
				_unregisterLinksRequestDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get
			{
				if (_focusModeActive == null)
				{
					_focusModeActive = (CBool) CR2WTypeManager.Create("Bool", "focusModeActive", cr2w, this);
				}
				return _focusModeActive;
			}
			set
			{
				if (_focusModeActive == value)
				{
					return;
				}
				_focusModeActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lastBeamResource")] 
		public gameFxResource LastBeamResource
		{
			get
			{
				if (_lastBeamResource == null)
				{
					_lastBeamResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "lastBeamResource", cr2w, this);
				}
				return _lastBeamResource;
			}
			set
			{
				if (_lastBeamResource == value)
				{
					return;
				}
				_lastBeamResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get
			{
				if (_pingNetworkEffect == null)
				{
					_pingNetworkEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "pingNetworkEffect", cr2w, this);
				}
				return _pingNetworkEffect;
			}
			set
			{
				if (_pingNetworkEffect == value)
				{
					return;
				}
				_pingNetworkEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("pingCachedData")] 
		public CHandle<PingCachedData> PingCachedData
		{
			get
			{
				if (_pingCachedData == null)
				{
					_pingCachedData = (CHandle<PingCachedData>) CR2WTypeManager.Create("handle:PingCachedData", "pingCachedData", cr2w, this);
				}
				return _pingCachedData;
			}
			set
			{
				if (_pingCachedData == value)
				{
					return;
				}
				_pingCachedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get
			{
				if (_lastPingSourceID == null)
				{
					_lastPingSourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastPingSourceID", cr2w, this);
				}
				return _lastPingSourceID;
			}
			set
			{
				if (_lastPingSourceID == value)
				{
					return;
				}
				_lastPingSourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("activePings")] 
		public CArray<CHandle<PingCachedData>> ActivePings
		{
			get
			{
				if (_activePings == null)
				{
					_activePings = (CArray<CHandle<PingCachedData>>) CR2WTypeManager.Create("array:handle:PingCachedData", "activePings", cr2w, this);
				}
				return _activePings;
			}
			set
			{
				if (_activePings == value)
				{
					return;
				}
				_activePings = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("pingLinksCounter")] 
		public CInt32 PingLinksCounter
		{
			get
			{
				if (_pingLinksCounter == null)
				{
					_pingLinksCounter = (CInt32) CR2WTypeManager.Create("Int32", "pingLinksCounter", cr2w, this);
				}
				return _pingLinksCounter;
			}
			set
			{
				if (_pingLinksCounter == value)
				{
					return;
				}
				_pingLinksCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("networkPresetTBDID")] 
		public TweakDBID NetworkPresetTBDID
		{
			get
			{
				if (_networkPresetTBDID == null)
				{
					_networkPresetTBDID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "networkPresetTBDID", cr2w, this);
				}
				return _networkPresetTBDID;
			}
			set
			{
				if (_networkPresetTBDID == value)
				{
					return;
				}
				_networkPresetTBDID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("networkPresetRecord")] 
		public wCHandle<gamedataNetworkPingingParameteres_Record> NetworkPresetRecord
		{
			get
			{
				if (_networkPresetRecord == null)
				{
					_networkPresetRecord = (wCHandle<gamedataNetworkPingingParameteres_Record>) CR2WTypeManager.Create("whandle:gamedataNetworkPingingParameteres_Record", "networkPresetRecord", cr2w, this);
				}
				return _networkPresetRecord;
			}
			set
			{
				if (_networkPresetRecord == value)
				{
					return;
				}
				_networkPresetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("backdoors")] 
		public CArray<gamePersistentID> Backdoors
		{
			get
			{
				if (_backdoors == null)
				{
					_backdoors = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "backdoors", cr2w, this);
				}
				return _backdoors;
			}
			set
			{
				if (_backdoors == value)
				{
					return;
				}
				_backdoors = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("revealedBackdoorsCount")] 
		public CInt32 RevealedBackdoorsCount
		{
			get
			{
				if (_revealedBackdoorsCount == null)
				{
					_revealedBackdoorsCount = (CInt32) CR2WTypeManager.Create("Int32", "revealedBackdoorsCount", cr2w, this);
				}
				return _revealedBackdoorsCount;
			}
			set
			{
				if (_revealedBackdoorsCount == value)
				{
					return;
				}
				_revealedBackdoorsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("debugCashedPingFxResource")] 
		public gameFxResource DebugCashedPingFxResource
		{
			get
			{
				if (_debugCashedPingFxResource == null)
				{
					_debugCashedPingFxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "debugCashedPingFxResource", cr2w, this);
				}
				return _debugCashedPingFxResource;
			}
			set
			{
				if (_debugCashedPingFxResource == value)
				{
					return;
				}
				_debugCashedPingFxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("debugQueryNumber")] 
		public CInt32 DebugQueryNumber
		{
			get
			{
				if (_debugQueryNumber == null)
				{
					_debugQueryNumber = (CInt32) CR2WTypeManager.Create("Int32", "debugQueryNumber", cr2w, this);
				}
				return _debugQueryNumber;
			}
			set
			{
				if (_debugQueryNumber == value)
				{
					return;
				}
				_debugQueryNumber = value;
				PropertySet(this);
			}
		}

		public NetworkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
