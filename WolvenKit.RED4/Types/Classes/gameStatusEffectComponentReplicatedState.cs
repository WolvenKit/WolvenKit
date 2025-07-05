using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("replicatedInfo")] 
		public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo
		{
			get => GetPropertyValue<CArray<gameStatusEffectReplicatedInfo>>();
			set => SetPropertyValue<CArray<gameStatusEffectReplicatedInfo>>(value);
		}

		public gameStatusEffectComponentReplicatedState()
		{
			Enabled = true;
			ReplicatedInfo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
