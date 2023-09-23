using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VaultDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		[Ordinal(4)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("shouldDisableEnterCondition")] 
		public CBool ShouldDisableEnterCondition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VaultDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
