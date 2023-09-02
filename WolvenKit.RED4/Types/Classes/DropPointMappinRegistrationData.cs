using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointMappinRegistrationData : IScriptable
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
		[RED("mapinID")] 
		public gameNewMappinID MapinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(3)] 
		[RED("trackingAlternativeMappinID")] 
		public gameNewMappinID TrackingAlternativeMappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		public DropPointMappinRegistrationData()
		{
			OwnerID = new entEntityID();
			Position = new Vector4();
			MapinID = new gameNewMappinID();
			TrackingAlternativeMappinID = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
