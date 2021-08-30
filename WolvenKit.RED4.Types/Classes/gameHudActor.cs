using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHudActor : IScriptable
	{
		private entEntityID _entityID;
		private CEnum<HUDActorType> _type;
		private CEnum<HUDActorStatus> _status;
		private CEnum<ActorVisibilityStatus> _visibility;
		private CArray<CWeakHandle<HUDModule>> _activeModules;
		private CBool _isRevealed;
		private CBool _isTagged;
		private HUDClueData _clueData;
		private CBool _isRemotelyAccessed;
		private CBool _canOpenScannerInfo;
		private CBool _isInIconForcedVisibilityRange;
		private CBool _isIconForcedVisibleThroughWalls;
		private CBool _shouldRefreshQHack;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("status")] 
		public CEnum<HUDActorStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CEnum<ActorVisibilityStatus> Visibility
		{
			get => GetProperty(ref _visibility);
			set => SetProperty(ref _visibility, value);
		}

		[Ordinal(4)] 
		[RED("activeModules")] 
		public CArray<CWeakHandle<HUDModule>> ActiveModules
		{
			get => GetProperty(ref _activeModules);
			set => SetProperty(ref _activeModules, value);
		}

		[Ordinal(5)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(6)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(7)] 
		[RED("clueData")] 
		public HUDClueData ClueData
		{
			get => GetProperty(ref _clueData);
			set => SetProperty(ref _clueData, value);
		}

		[Ordinal(8)] 
		[RED("isRemotelyAccessed")] 
		public CBool IsRemotelyAccessed
		{
			get => GetProperty(ref _isRemotelyAccessed);
			set => SetProperty(ref _isRemotelyAccessed, value);
		}

		[Ordinal(9)] 
		[RED("canOpenScannerInfo")] 
		public CBool CanOpenScannerInfo
		{
			get => GetProperty(ref _canOpenScannerInfo);
			set => SetProperty(ref _canOpenScannerInfo, value);
		}

		[Ordinal(10)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetProperty(ref _isInIconForcedVisibilityRange);
			set => SetProperty(ref _isInIconForcedVisibilityRange, value);
		}

		[Ordinal(11)] 
		[RED("isIconForcedVisibleThroughWalls")] 
		public CBool IsIconForcedVisibleThroughWalls
		{
			get => GetProperty(ref _isIconForcedVisibleThroughWalls);
			set => SetProperty(ref _isIconForcedVisibleThroughWalls, value);
		}

		[Ordinal(12)] 
		[RED("shouldRefreshQHack")] 
		public CBool ShouldRefreshQHack
		{
			get => GetProperty(ref _shouldRefreshQHack);
			set => SetProperty(ref _shouldRefreshQHack, value);
		}

		public gameHudActor()
		{
			_shouldRefreshQHack = true;
		}
	}
}
