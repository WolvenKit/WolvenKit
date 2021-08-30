using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimGraph : CResource
	{
		private CHandle<animAnimNode_Root> _rootNode;
		private CHandle<animAnimVariableContainer> _variables;
		private CArray<animAnimFeatureEntry> _animFeatures;
		private CFloat _timeDeltaMultiplier;
		private CBool _isPaused;
		private CBool _oneFrameToggle;
		private CBool _hasMixerSlot;
		private CArray<animAnimDatabaseCollectionEntry> _additionalAnimDatabases;
		private CArray<CHandle<animAnimNode_Base>> _nodesToInit;
		private CBool _useLunaticMode;
		private CBool _useAnimCommands;
		private CBool _useAnimCommandsForCrowd;
		private CBool _useAnimStaticCommands;
		private CResourceReference<animRig> _staticCommandsRig;
		private CBool _hackAlwaysSample;

		[Ordinal(1)] 
		[RED("rootNode")] 
		public CHandle<animAnimNode_Root> RootNode
		{
			get => GetProperty(ref _rootNode);
			set => SetProperty(ref _rootNode, value);
		}

		[Ordinal(2)] 
		[RED("variables")] 
		public CHandle<animAnimVariableContainer> Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}

		[Ordinal(3)] 
		[RED("animFeatures")] 
		public CArray<animAnimFeatureEntry> AnimFeatures
		{
			get => GetProperty(ref _animFeatures);
			set => SetProperty(ref _animFeatures, value);
		}

		[Ordinal(4)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get => GetProperty(ref _timeDeltaMultiplier);
			set => SetProperty(ref _timeDeltaMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		[Ordinal(6)] 
		[RED("oneFrameToggle")] 
		public CBool OneFrameToggle
		{
			get => GetProperty(ref _oneFrameToggle);
			set => SetProperty(ref _oneFrameToggle, value);
		}

		[Ordinal(7)] 
		[RED("hasMixerSlot")] 
		public CBool HasMixerSlot
		{
			get => GetProperty(ref _hasMixerSlot);
			set => SetProperty(ref _hasMixerSlot, value);
		}

		[Ordinal(8)] 
		[RED("additionalAnimDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AdditionalAnimDatabases
		{
			get => GetProperty(ref _additionalAnimDatabases);
			set => SetProperty(ref _additionalAnimDatabases, value);
		}

		[Ordinal(9)] 
		[RED("nodesToInit")] 
		public CArray<CHandle<animAnimNode_Base>> NodesToInit
		{
			get => GetProperty(ref _nodesToInit);
			set => SetProperty(ref _nodesToInit, value);
		}

		[Ordinal(10)] 
		[RED("useLunaticMode")] 
		public CBool UseLunaticMode
		{
			get => GetProperty(ref _useLunaticMode);
			set => SetProperty(ref _useLunaticMode, value);
		}

		[Ordinal(11)] 
		[RED("useAnimCommands")] 
		public CBool UseAnimCommands
		{
			get => GetProperty(ref _useAnimCommands);
			set => SetProperty(ref _useAnimCommands, value);
		}

		[Ordinal(12)] 
		[RED("useAnimCommandsForCrowd")] 
		public CBool UseAnimCommandsForCrowd
		{
			get => GetProperty(ref _useAnimCommandsForCrowd);
			set => SetProperty(ref _useAnimCommandsForCrowd, value);
		}

		[Ordinal(13)] 
		[RED("useAnimStaticCommands")] 
		public CBool UseAnimStaticCommands
		{
			get => GetProperty(ref _useAnimStaticCommands);
			set => SetProperty(ref _useAnimStaticCommands, value);
		}

		[Ordinal(14)] 
		[RED("staticCommandsRig")] 
		public CResourceReference<animRig> StaticCommandsRig
		{
			get => GetProperty(ref _staticCommandsRig);
			set => SetProperty(ref _staticCommandsRig, value);
		}

		[Ordinal(15)] 
		[RED("hackAlwaysSample")] 
		public CBool HackAlwaysSample
		{
			get => GetProperty(ref _hackAlwaysSample);
			set => SetProperty(ref _hackAlwaysSample, value);
		}

		public animAnimGraph()
		{
			_timeDeltaMultiplier = 1.000000F;
		}
	}
}
