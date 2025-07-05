using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRagdollComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		[Ordinal(3)] 
		[RED("isSleeping")] 
		public CBool IsSleeping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entRagdollComponentReplicatedState()
		{
			Enabled = true;
			Transforms = new();
			IsSleeping = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
