using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWorkspotParamsV1 : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questUseWorkspotNodeFunctions> Function
		{
			get => GetPropertyValue<CEnum<questUseWorkspotNodeFunctions>>();
			set => SetPropertyValue<CEnum<questUseWorkspotNodeFunctions>>(value);
		}

		[Ordinal(1)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("teleport")] 
		public CBool Teleport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("finishAnimation")] 
		public CBool FinishAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(7)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("changeWorkspot")] 
		public CBool ChangeWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("enableIdleMode")] 
		public CBool EnableIdleMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("exitEntryId")] 
		public workWorkEntryId ExitEntryId
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(11)] 
		[RED("exitAnimName")] 
		public CName ExitAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("playerParams")] 
		public questUseWorkspotPlayerParams PlayerParams
		{
			get => GetPropertyValue<questUseWorkspotPlayerParams>();
			set => SetPropertyValue<questUseWorkspotPlayerParams>(value);
		}

		[Ordinal(16)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetPropertyValue<CArray<workWorkEntryId>>();
			set => SetPropertyValue<CArray<workWorkEntryId>>(value);
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(19)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("maxAnimTimeLimit")] 
		public CFloat MaxAnimTimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("meshDissolvingEnabled")] 
		public CBool MeshDissolvingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questUseWorkspotParamsV1()
		{
			Teleport = true;
			FinishAnimation = true;
			EntryId = new() { Id = 4294967295 };
			ChangeWorkspot = true;
			ExitEntryId = new() { Id = 4294967295 };
			IsWorkspotInfinite = true;
			PlayerParams = new() { CameraSettings = new() { YawLeftLimit = 60.000000F, YawRightLimit = 60.000000F, PitchTopLimit = 60.000000F, PitchBottomLimit = 45.000000F, PitchSpeedMultiplier = 1.000000F, YawSpeedMultiplier = 1.000000F }, CameraUseTrajectorySpace = true, VehicleProceduralCameraWeight = 1.000000F, ParallaxWeight = 1.000000F };
			RepeatCommandOnInterrupt = true;
			WorkExcludedGestures = new();
			MeshDissolvingEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
