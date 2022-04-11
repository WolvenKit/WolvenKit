using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHudActor : IScriptable
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get => GetPropertyValue<CEnum<HUDActorType>>();
			set => SetPropertyValue<CEnum<HUDActorType>>(value);
		}

		[Ordinal(2)] 
		[RED("status")] 
		public CEnum<HUDActorStatus> Status
		{
			get => GetPropertyValue<CEnum<HUDActorStatus>>();
			set => SetPropertyValue<CEnum<HUDActorStatus>>(value);
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CEnum<ActorVisibilityStatus> Visibility
		{
			get => GetPropertyValue<CEnum<ActorVisibilityStatus>>();
			set => SetPropertyValue<CEnum<ActorVisibilityStatus>>(value);
		}

		[Ordinal(4)] 
		[RED("activeModules")] 
		public CArray<CWeakHandle<HUDModule>> ActiveModules
		{
			get => GetPropertyValue<CArray<CWeakHandle<HUDModule>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HUDModule>>>(value);
		}

		[Ordinal(5)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("clueData")] 
		public HUDClueData ClueData
		{
			get => GetPropertyValue<HUDClueData>();
			set => SetPropertyValue<HUDClueData>(value);
		}

		[Ordinal(8)] 
		[RED("isRemotelyAccessed")] 
		public CBool IsRemotelyAccessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("canOpenScannerInfo")] 
		public CBool CanOpenScannerInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isIconForcedVisibleThroughWalls")] 
		public CBool IsIconForcedVisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("shouldRefreshQHack")] 
		public CBool ShouldRefreshQHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameHudActor()
		{
			EntityID = new();
			ActiveModules = new();
			ClueData = new();
			ShouldRefreshQHack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
