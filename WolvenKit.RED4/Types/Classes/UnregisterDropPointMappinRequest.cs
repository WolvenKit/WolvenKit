using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("removeFromSystem")] 
		public CBool RemoveFromSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnregisterDropPointMappinRequest()
		{
			OwnerID = new();
			RemoveFromSystem = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
