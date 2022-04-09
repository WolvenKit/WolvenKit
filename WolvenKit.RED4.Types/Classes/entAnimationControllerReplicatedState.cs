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
			AnimWrapperVarsState = new() { ServerReplicatedTime = new(), Data = new() };
			AnimFeaturesState = new() { Items = new(), LastAppliedActionsTime = new() };
			InputSettersState = new() { ServerReplicatedTime = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
