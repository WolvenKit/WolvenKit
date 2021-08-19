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
		private CHandle<redCallbackObject> _visionModeChangedCallback;
		private CHandle<redCallbackObject> _focusModeToggleCallback;
		private CUInt32 _playerSpawnCallback;
		private CHandle<redCallbackObject> _currentPlayerTargetCallbackID;
		private entEntityID _lastTargetSlaveID;
		private entEntityID _lastTargetMasterID;
		private gameDelayID _unregisterLinksRequestDelay;
		private CBool _focusModeActive;
		private gameFxResource _lastBeamResource;
		private CHandle<gameEffectInstance> _pingNetworkEffect;
		private CHandle<PingCachedData> _pingCachedData;
		private entEntityID _lastPingSourceID;
		private CArray<CHandle<PingCachedData>> _activePings;
		private CArray<CName> _pingedSquads;
		private CInt32 _pingLinksCounter;
		private TweakDBID _networkPresetTBDID;
		private wCHandle<gamedataNetworkPingingParameteres_Record> _networkPresetRecord;
		private CArray<gamePersistentID> _backdoors;
		private CInt32 _revealedBackdoorsCount;
		private gameFxResource _debugCashedPingFxResource;
		private CInt32 _debugQueryNumber;
		private gameDelayID _activateLinksDelayID;
		private gameDelayID _deactivateLinksDelayID;

		[Ordinal(0)] 
		[RED("networkLinks")] 
		public CArray<SNetworkLinkData> NetworkLinks
		{
			get => GetProperty(ref _networkLinks);
			set => SetProperty(ref _networkLinks, value);
		}

		[Ordinal(1)] 
		[RED("networkRevealTargets")] 
		public CArray<entEntityID> NetworkRevealTargets
		{
			get => GetProperty(ref _networkRevealTargets);
			set => SetProperty(ref _networkRevealTargets, value);
		}

		[Ordinal(2)] 
		[RED("sessionStarted")] 
		public CBool SessionStarted
		{
			get => GetProperty(ref _sessionStarted);
			set => SetProperty(ref _sessionStarted, value);
		}

		[Ordinal(3)] 
		[RED("visionModeChangedCallback")] 
		public CHandle<redCallbackObject> VisionModeChangedCallback
		{
			get => GetProperty(ref _visionModeChangedCallback);
			set => SetProperty(ref _visionModeChangedCallback, value);
		}

		[Ordinal(4)] 
		[RED("focusModeToggleCallback")] 
		public CHandle<redCallbackObject> FocusModeToggleCallback
		{
			get => GetProperty(ref _focusModeToggleCallback);
			set => SetProperty(ref _focusModeToggleCallback, value);
		}

		[Ordinal(5)] 
		[RED("playerSpawnCallback")] 
		public CUInt32 PlayerSpawnCallback
		{
			get => GetProperty(ref _playerSpawnCallback);
			set => SetProperty(ref _playerSpawnCallback, value);
		}

		[Ordinal(6)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CHandle<redCallbackObject> CurrentPlayerTargetCallbackID
		{
			get => GetProperty(ref _currentPlayerTargetCallbackID);
			set => SetProperty(ref _currentPlayerTargetCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("lastTargetSlaveID")] 
		public entEntityID LastTargetSlaveID
		{
			get => GetProperty(ref _lastTargetSlaveID);
			set => SetProperty(ref _lastTargetSlaveID, value);
		}

		[Ordinal(8)] 
		[RED("lastTargetMasterID")] 
		public entEntityID LastTargetMasterID
		{
			get => GetProperty(ref _lastTargetMasterID);
			set => SetProperty(ref _lastTargetMasterID, value);
		}

		[Ordinal(9)] 
		[RED("unregisterLinksRequestDelay")] 
		public gameDelayID UnregisterLinksRequestDelay
		{
			get => GetProperty(ref _unregisterLinksRequestDelay);
			set => SetProperty(ref _unregisterLinksRequestDelay, value);
		}

		[Ordinal(10)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetProperty(ref _focusModeActive);
			set => SetProperty(ref _focusModeActive, value);
		}

		[Ordinal(11)] 
		[RED("lastBeamResource")] 
		public gameFxResource LastBeamResource
		{
			get => GetProperty(ref _lastBeamResource);
			set => SetProperty(ref _lastBeamResource, value);
		}

		[Ordinal(12)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get => GetProperty(ref _pingNetworkEffect);
			set => SetProperty(ref _pingNetworkEffect, value);
		}

		[Ordinal(13)] 
		[RED("pingCachedData")] 
		public CHandle<PingCachedData> PingCachedData
		{
			get => GetProperty(ref _pingCachedData);
			set => SetProperty(ref _pingCachedData, value);
		}

		[Ordinal(14)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get => GetProperty(ref _lastPingSourceID);
			set => SetProperty(ref _lastPingSourceID, value);
		}

		[Ordinal(15)] 
		[RED("activePings")] 
		public CArray<CHandle<PingCachedData>> ActivePings
		{
			get => GetProperty(ref _activePings);
			set => SetProperty(ref _activePings, value);
		}

		[Ordinal(16)] 
		[RED("pingedSquads")] 
		public CArray<CName> PingedSquads
		{
			get => GetProperty(ref _pingedSquads);
			set => SetProperty(ref _pingedSquads, value);
		}

		[Ordinal(17)] 
		[RED("pingLinksCounter")] 
		public CInt32 PingLinksCounter
		{
			get => GetProperty(ref _pingLinksCounter);
			set => SetProperty(ref _pingLinksCounter, value);
		}

		[Ordinal(18)] 
		[RED("networkPresetTBDID")] 
		public TweakDBID NetworkPresetTBDID
		{
			get => GetProperty(ref _networkPresetTBDID);
			set => SetProperty(ref _networkPresetTBDID, value);
		}

		[Ordinal(19)] 
		[RED("networkPresetRecord")] 
		public wCHandle<gamedataNetworkPingingParameteres_Record> NetworkPresetRecord
		{
			get => GetProperty(ref _networkPresetRecord);
			set => SetProperty(ref _networkPresetRecord, value);
		}

		[Ordinal(20)] 
		[RED("backdoors")] 
		public CArray<gamePersistentID> Backdoors
		{
			get => GetProperty(ref _backdoors);
			set => SetProperty(ref _backdoors, value);
		}

		[Ordinal(21)] 
		[RED("revealedBackdoorsCount")] 
		public CInt32 RevealedBackdoorsCount
		{
			get => GetProperty(ref _revealedBackdoorsCount);
			set => SetProperty(ref _revealedBackdoorsCount, value);
		}

		[Ordinal(22)] 
		[RED("debugCashedPingFxResource")] 
		public gameFxResource DebugCashedPingFxResource
		{
			get => GetProperty(ref _debugCashedPingFxResource);
			set => SetProperty(ref _debugCashedPingFxResource, value);
		}

		[Ordinal(23)] 
		[RED("debugQueryNumber")] 
		public CInt32 DebugQueryNumber
		{
			get => GetProperty(ref _debugQueryNumber);
			set => SetProperty(ref _debugQueryNumber, value);
		}

		[Ordinal(24)] 
		[RED("activateLinksDelayID")] 
		public gameDelayID ActivateLinksDelayID
		{
			get => GetProperty(ref _activateLinksDelayID);
			set => SetProperty(ref _activateLinksDelayID, value);
		}

		[Ordinal(25)] 
		[RED("deactivateLinksDelayID")] 
		public gameDelayID DeactivateLinksDelayID
		{
			get => GetProperty(ref _deactivateLinksDelayID);
			set => SetProperty(ref _deactivateLinksDelayID, value);
		}

		public NetworkSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
