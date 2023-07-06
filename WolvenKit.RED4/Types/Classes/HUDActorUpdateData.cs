using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDActorUpdateData : IScriptable
	{
		[Ordinal(0)] 
		[RED("updateVisibility")] 
		public CBool UpdateVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("visibilityValue")] 
		public CEnum<ActorVisibilityStatus> VisibilityValue
		{
			get => GetPropertyValue<CEnum<ActorVisibilityStatus>>();
			set => SetPropertyValue<CEnum<ActorVisibilityStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("updateIsRevealed")] 
		public CBool UpdateIsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isRevealedValue")] 
		public CBool IsRevealedValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("updateIsTagged")] 
		public CBool UpdateIsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isTaggedValue")] 
		public CBool IsTaggedValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("updateClueData")] 
		public CBool UpdateClueData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("clueDataValue")] 
		public HUDClueData ClueDataValue
		{
			get => GetPropertyValue<HUDClueData>();
			set => SetPropertyValue<HUDClueData>(value);
		}

		[Ordinal(8)] 
		[RED("updateIsRemotelyAccessed")] 
		public CBool UpdateIsRemotelyAccessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isRemotelyAccessedValue")] 
		public CBool IsRemotelyAccessedValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("updateCanOpenScannerInfo")] 
		public CBool UpdateCanOpenScannerInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("canOpenScannerInfoValue")] 
		public CBool CanOpenScannerInfoValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("updateIsInIconForcedVisibilityRange")] 
		public CBool UpdateIsInIconForcedVisibilityRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isInIconForcedVisibilityRangeValue")] 
		public CBool IsInIconForcedVisibilityRangeValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("updateIsIconForcedVisibleThroughWalls")] 
		public CBool UpdateIsIconForcedVisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isIconForcedVisibleThroughWallsValue")] 
		public CBool IsIconForcedVisibleThroughWallsValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HUDActorUpdateData()
		{
			ClueDataValue = new HUDClueData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
