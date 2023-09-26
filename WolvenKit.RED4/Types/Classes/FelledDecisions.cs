using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FelledDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("felled")] 
		public CBool Felled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		public FelledDecisions()
		{
			CallbackIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
