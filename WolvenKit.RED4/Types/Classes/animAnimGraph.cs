using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimGraph : CResource
	{
		[Ordinal(1)] 
		[RED("rootNode")] 
		public CHandle<animAnimNode_Root> RootNode
		{
			get => GetPropertyValue<CHandle<animAnimNode_Root>>();
			set => SetPropertyValue<CHandle<animAnimNode_Root>>(value);
		}

		[Ordinal(2)] 
		[RED("variables")] 
		public CHandle<animAnimVariableContainer> Variables
		{
			get => GetPropertyValue<CHandle<animAnimVariableContainer>>();
			set => SetPropertyValue<CHandle<animAnimVariableContainer>>(value);
		}

		[Ordinal(3)] 
		[RED("animFeatures")] 
		public CArray<animAnimFeatureEntry> AnimFeatures
		{
			get => GetPropertyValue<CArray<animAnimFeatureEntry>>();
			set => SetPropertyValue<CArray<animAnimFeatureEntry>>(value);
		}

		[Ordinal(4)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("oneFrameToggle")] 
		public CBool OneFrameToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("hasMixerSlot")] 
		public CBool HasMixerSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("additionalAnimDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AdditionalAnimDatabases
		{
			get => GetPropertyValue<CArray<animAnimDatabaseCollectionEntry>>();
			set => SetPropertyValue<CArray<animAnimDatabaseCollectionEntry>>(value);
		}

		[Ordinal(9)] 
		[RED("nodesToInit")] 
		public CArray<CHandle<animAnimNode_Base>> NodesToInit
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNode_Base>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNode_Base>>>(value);
		}

		[Ordinal(10)] 
		[RED("useLunaticMode")] 
		public CBool UseLunaticMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("useAnimCommands")] 
		public CBool UseAnimCommands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useAnimCommandsForCrowd")] 
		public CBool UseAnimCommandsForCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useAnimStaticCommands")] 
		public CBool UseAnimStaticCommands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("staticCommandsRig")] 
		public CResourceReference<animRig> StaticCommandsRig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(15)] 
		[RED("hackAlwaysSample")] 
		public CBool HackAlwaysSample
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimGraph()
		{
			AnimFeatures = new();
			TimeDeltaMultiplier = 1.000000F;
			AdditionalAnimDatabases = new();
			NodesToInit = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
