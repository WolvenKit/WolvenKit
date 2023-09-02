using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimationControllerReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("animWrapperVarsState")] 
		public entReplicatedAnimWrapperVars AnimWrapperVarsState
		{
			get => GetPropertyValue<entReplicatedAnimWrapperVars>();
			set => SetPropertyValue<entReplicatedAnimWrapperVars>(value);
		}

		[Ordinal(3)] 
		[RED("lookAtReqs.m_replicatedVersionId")] 
		public CUInt32 LookAtReqs_m_replicatedVersionId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("animFeaturesState")] 
		public entReplicatedAnimFeaturesState AnimFeaturesState
		{
			get => GetPropertyValue<entReplicatedAnimFeaturesState>();
			set => SetPropertyValue<entReplicatedAnimFeaturesState>(value);
		}

		[Ordinal(5)] 
		[RED("inputSettersState")] 
		public entReplicatedInputSetters InputSettersState
		{
			get => GetPropertyValue<entReplicatedInputSetters>();
			set => SetPropertyValue<entReplicatedInputSetters>(value);
		}

		public entAnimationControllerReplicatedState()
		{
			Enabled = true;
			AnimWrapperVarsState = new entReplicatedAnimWrapperVars { ServerReplicatedTime = new netTime(), Data = new() };
			AnimFeaturesState = new entReplicatedAnimFeaturesState { Items = new(), LastAppliedActionsTime = new netTime() };
			InputSettersState = new entReplicatedInputSetters { ServerReplicatedTime = new netTime() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
