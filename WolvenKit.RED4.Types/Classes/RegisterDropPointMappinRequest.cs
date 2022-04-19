using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("trackingAlternativeMappinID")] 
		public gameNewMappinID TrackingAlternativeMappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		public RegisterDropPointMappinRequest()
		{
			OwnerID = new();
			Position = new();
			TrackingAlternativeMappinID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
