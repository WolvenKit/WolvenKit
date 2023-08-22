using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("globalProps")] 
		public CArray<workWorkspotGlobalProp> GlobalProps
		{
			get => GetPropertyValue<CArray<workWorkspotGlobalProp>>();
			set => SetPropertyValue<CArray<workWorkspotGlobalProp>>(value);
		}

		[Ordinal(2)] 
		[RED("rootEntry")] 
		public CHandle<workIEntry> RootEntry
		{
			get => GetPropertyValue<CHandle<workIEntry>>();
			set => SetPropertyValue<CHandle<workIEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("idCounter")] 
		public CUInt32 IdCounter
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("dontInjectWorkspotGraph")] 
		public CBool DontInjectWorkspotGraph
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("animGraphSlotName")] 
		public CName AnimGraphSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("autoTransitionBlendTime")] 
		public CFloat AutoTransitionBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("initialActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> InitialActions
		{
			get => GetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>();
			set => SetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>(value);
		}

		[Ordinal(8)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("finalAnimsets")] 
		public CArray<workWorkspotAnimsetEntry> FinalAnimsets
		{
			get => GetPropertyValue<CArray<workWorkspotAnimsetEntry>>();
			set => SetPropertyValue<CArray<workWorkspotAnimsetEntry>>(value);
		}

		[Ordinal(10)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(11)] 
		[RED("itemsPolicy")] 
		public CBitField<workWorkspotItemPolicy> ItemsPolicy
		{
			get => GetPropertyValue<CBitField<workWorkspotItemPolicy>>();
			set => SetPropertyValue<CBitField<workWorkspotItemPolicy>>(value);
		}

		[Ordinal(12)] 
		[RED("censorshipFlags")] 
		public CBitField<CensorshipFlags> CensorshipFlags
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		[Ordinal(13)] 
		[RED("customTransitionAnims")] 
		public CArray<workTransitionAnim> CustomTransitionAnims
		{
			get => GetPropertyValue<CArray<workTransitionAnim>>();
			set => SetPropertyValue<CArray<workTransitionAnim>>(value);
		}

		[Ordinal(14)] 
		[RED("inertializationDurationEnter")] 
		public CFloat InertializationDurationEnter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("inertializationDurationExitNatural")] 
		public CFloat InertializationDurationExitNatural
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("inertializationDurationExitForced")] 
		public CFloat InertializationDurationExitForced
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("useTimeLimitForSequences")] 
		public CBool UseTimeLimitForSequences
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("frezeAtTheLastFrame_UseWithCaution")] 
		public CBool FrezeAtTheLastFrame_UseWithCaution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("sequencesTimeLimit")] 
		public CFloat SequencesTimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(23)] 
		[RED("whitelistVisualTags")] 
		public redTagList WhitelistVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(24)] 
		[RED("blacklistVisualTags")] 
		public redTagList BlacklistVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public workWorkspotTree()
		{
			GlobalProps = new();
			AnimGraphSlotName = "WORKSPOT";
			AutoTransitionBlendTime = 1.000000F;
			InitialActions = new();
			FinalAnimsets = new();
			Tags = new redTagList { Tags = new() };
			ItemsPolicy = Enums.workWorkspotItemPolicy.ItemPolicy_SpawnItemOnIdleChange | Enums.workWorkspotItemPolicy.ItemPolicy_DespawnItemOnIdleChange | Enums.workWorkspotItemPolicy.ItemPolicy_DespawnItemOnReaction;
			CustomTransitionAnims = new();
			InertializationDurationEnter = 0.500000F;
			InertializationDurationExitNatural = 0.500000F;
			InertializationDurationExitForced = 0.200000F;
			SequencesTimeLimit = 1.000000F;
			UnmountBodyCarry = true;
			WhitelistVisualTags = new redTagList { Tags = new() };
			BlacklistVisualTags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
