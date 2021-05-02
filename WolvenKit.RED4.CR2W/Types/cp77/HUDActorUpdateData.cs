using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDActorUpdateData : IScriptable
	{
		private CBool _updateVisibility;
		private CEnum<ActorVisibilityStatus> _visibilityValue;
		private CBool _updateIsRevealed;
		private CBool _isRevealedValue;
		private CBool _updateIsTagged;
		private CBool _isTaggedValue;
		private CBool _updateClueData;
		private HUDClueData _clueDataValue;
		private CBool _updateIsRemotelyAccessed;
		private CBool _isRemotelyAccessedValue;
		private CBool _updateCanOpenScannerInfo;
		private CBool _canOpenScannerInfoValue;
		private CBool _updateIsInIconForcedVisibilityRange;
		private CBool _isInIconForcedVisibilityRangeValue;
		private CBool _updateIsIconForcedVisibleThroughWalls;
		private CBool _isIconForcedVisibleThroughWallsValue;

		[Ordinal(0)] 
		[RED("updateVisibility")] 
		public CBool UpdateVisibility
		{
			get => GetProperty(ref _updateVisibility);
			set => SetProperty(ref _updateVisibility, value);
		}

		[Ordinal(1)] 
		[RED("visibilityValue")] 
		public CEnum<ActorVisibilityStatus> VisibilityValue
		{
			get => GetProperty(ref _visibilityValue);
			set => SetProperty(ref _visibilityValue, value);
		}

		[Ordinal(2)] 
		[RED("updateIsRevealed")] 
		public CBool UpdateIsRevealed
		{
			get => GetProperty(ref _updateIsRevealed);
			set => SetProperty(ref _updateIsRevealed, value);
		}

		[Ordinal(3)] 
		[RED("isRevealedValue")] 
		public CBool IsRevealedValue
		{
			get => GetProperty(ref _isRevealedValue);
			set => SetProperty(ref _isRevealedValue, value);
		}

		[Ordinal(4)] 
		[RED("updateIsTagged")] 
		public CBool UpdateIsTagged
		{
			get => GetProperty(ref _updateIsTagged);
			set => SetProperty(ref _updateIsTagged, value);
		}

		[Ordinal(5)] 
		[RED("isTaggedValue")] 
		public CBool IsTaggedValue
		{
			get => GetProperty(ref _isTaggedValue);
			set => SetProperty(ref _isTaggedValue, value);
		}

		[Ordinal(6)] 
		[RED("updateClueData")] 
		public CBool UpdateClueData
		{
			get => GetProperty(ref _updateClueData);
			set => SetProperty(ref _updateClueData, value);
		}

		[Ordinal(7)] 
		[RED("clueDataValue")] 
		public HUDClueData ClueDataValue
		{
			get => GetProperty(ref _clueDataValue);
			set => SetProperty(ref _clueDataValue, value);
		}

		[Ordinal(8)] 
		[RED("updateIsRemotelyAccessed")] 
		public CBool UpdateIsRemotelyAccessed
		{
			get => GetProperty(ref _updateIsRemotelyAccessed);
			set => SetProperty(ref _updateIsRemotelyAccessed, value);
		}

		[Ordinal(9)] 
		[RED("isRemotelyAccessedValue")] 
		public CBool IsRemotelyAccessedValue
		{
			get => GetProperty(ref _isRemotelyAccessedValue);
			set => SetProperty(ref _isRemotelyAccessedValue, value);
		}

		[Ordinal(10)] 
		[RED("updateCanOpenScannerInfo")] 
		public CBool UpdateCanOpenScannerInfo
		{
			get => GetProperty(ref _updateCanOpenScannerInfo);
			set => SetProperty(ref _updateCanOpenScannerInfo, value);
		}

		[Ordinal(11)] 
		[RED("canOpenScannerInfoValue")] 
		public CBool CanOpenScannerInfoValue
		{
			get => GetProperty(ref _canOpenScannerInfoValue);
			set => SetProperty(ref _canOpenScannerInfoValue, value);
		}

		[Ordinal(12)] 
		[RED("updateIsInIconForcedVisibilityRange")] 
		public CBool UpdateIsInIconForcedVisibilityRange
		{
			get => GetProperty(ref _updateIsInIconForcedVisibilityRange);
			set => SetProperty(ref _updateIsInIconForcedVisibilityRange, value);
		}

		[Ordinal(13)] 
		[RED("isInIconForcedVisibilityRangeValue")] 
		public CBool IsInIconForcedVisibilityRangeValue
		{
			get => GetProperty(ref _isInIconForcedVisibilityRangeValue);
			set => SetProperty(ref _isInIconForcedVisibilityRangeValue, value);
		}

		[Ordinal(14)] 
		[RED("updateIsIconForcedVisibleThroughWalls")] 
		public CBool UpdateIsIconForcedVisibleThroughWalls
		{
			get => GetProperty(ref _updateIsIconForcedVisibleThroughWalls);
			set => SetProperty(ref _updateIsIconForcedVisibleThroughWalls, value);
		}

		[Ordinal(15)] 
		[RED("isIconForcedVisibleThroughWallsValue")] 
		public CBool IsIconForcedVisibleThroughWallsValue
		{
			get => GetProperty(ref _isIconForcedVisibleThroughWallsValue);
			set => SetProperty(ref _isIconForcedVisibleThroughWallsValue, value);
		}

		public HUDActorUpdateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
