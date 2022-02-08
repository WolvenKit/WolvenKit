using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotTree : ISerializable
	{
		[Ordinal(0)] 
		[RED("workspotRig")] 
		public CResourceAsyncReference<animRig> WorkspotRig
		{
			get => GetPropertyValue<CResourceAsyncReference<animRig>>();
			set => SetPropertyValue<CResourceAsyncReference<animRig>>(value);
		}

		[Ordinal(1)] 
		[RED("availableRigSlots")] 
		public CArray<CName> AvailableRigSlots
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("availablePropIds")] 
		public CArray<CName> AvailablePropIds
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("globalProps")] 
		public CArray<workWorkspotGlobalProp> GlobalProps
		{
			get => GetPropertyValue<CArray<workWorkspotGlobalProp>>();
			set => SetPropertyValue<CArray<workWorkspotGlobalProp>>(value);
		}

		[Ordinal(4)] 
		[RED("rootEntry")] 
		public CHandle<workIEntry> RootEntry
		{
			get => GetPropertyValue<CHandle<workIEntry>>();
			set => SetPropertyValue<CHandle<workIEntry>>(value);
		}

		[Ordinal(5)] 
		[RED("idCounter")] 
		public CUInt32 IdCounter
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("dontInjectWorkspotGraph")] 
		public CBool DontInjectWorkspotGraph
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("animGraphSlotName")] 
		public CName AnimGraphSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("autoTransitionBlendTime")] 
		public CFloat AutoTransitionBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("initialActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> InitialActions
		{
			get => GetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>();
			set => SetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>(value);
		}

		[Ordinal(10)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("hasEntityPathsGenerated")] 
		public CBool HasEntityPathsGenerated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("entitiesPaths")] 
		public CArray<CName> EntitiesPaths
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(13)] 
		[RED("animsets")] 
		public CArray<workWorkspotAnimsetEntry> Animsets
		{
			get => GetPropertyValue<CArray<workWorkspotAnimsetEntry>>();
			set => SetPropertyValue<CArray<workWorkspotAnimsetEntry>>(value);
		}

		[Ordinal(14)] 
		[RED("finalAnimsets")] 
		public CArray<workWorkspotAnimsetEntry> FinalAnimsets
		{
			get => GetPropertyValue<CArray<workWorkspotAnimsetEntry>>();
			set => SetPropertyValue<CArray<workWorkspotAnimsetEntry>>(value);
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(16)] 
		[RED("itemsPolicy")] 
		public CBitField<workWorkspotItemPolicy> ItemsPolicy
		{
			get => GetPropertyValue<CBitField<workWorkspotItemPolicy>>();
			set => SetPropertyValue<CBitField<workWorkspotItemPolicy>>(value);
		}

		[Ordinal(17)] 
		[RED("censorshipFlags")] 
		public CBitField<CensorshipFlags> CensorshipFlags
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		[Ordinal(18)] 
		[RED("customTransitionAnims")] 
		public CArray<workTransitionAnim> CustomTransitionAnims
		{
			get => GetPropertyValue<CArray<workTransitionAnim>>();
			set => SetPropertyValue<CArray<workTransitionAnim>>(value);
		}

		[Ordinal(19)] 
		[RED("inertializationDurationEnter")] 
		public CFloat InertializationDurationEnter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("inertializationDurationExitNatural")] 
		public CFloat InertializationDurationExitNatural
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("inertializationDurationExitForced")] 
		public CFloat InertializationDurationExitForced
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("useTimeLimitForSequences")] 
		public CBool UseTimeLimitForSequences
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("disableAutoAnimsetGeneraion")] 
		public CBool DisableAutoAnimsetGeneraion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("frezeAtTheLastFrame_UseWithCaution")] 
		public CBool FrezeAtTheLastFrame_UseWithCaution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("sequencesTimeLimit")] 
		public CFloat SequencesTimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(29)] 
		[RED("whitelistVisualTags")] 
		public redTagList WhitelistVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(30)] 
		[RED("blacklistVisualTags")] 
		public redTagList BlacklistVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public workWorkspotTree()
		{
			AvailableRigSlots = new();
			AvailablePropIds = new();
			GlobalProps = new();
			AnimGraphSlotName = "WORKSPOT";
			AutoTransitionBlendTime = 1.000000F;
			InitialActions = new();
			EntitiesPaths = new();
			Animsets = new();
			FinalAnimsets = new();
			Tags = new() { Tags = new() };
			ItemsPolicy = Enums.workWorkspotItemPolicy.ItemPolicy_SpawnItemOnIdleChange | Enums.workWorkspotItemPolicy.ItemPolicy_DespawnItemOnIdleChange | Enums.workWorkspotItemPolicy.ItemPolicy_DespawnItemOnReaction;
			CustomTransitionAnims = new();
			InertializationDurationEnter = 0.500000F;
			InertializationDurationExitNatural = 0.500000F;
			InertializationDurationExitForced = 0.200000F;
			SequencesTimeLimit = 1.000000F;
			UnmountBodyCarry = true;
			WhitelistVisualTags = new() { Tags = new() };
			BlacklistVisualTags = new() { Tags = new() };
		}
	}
}
