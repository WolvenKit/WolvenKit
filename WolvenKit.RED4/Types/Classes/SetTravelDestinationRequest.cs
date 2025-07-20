using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetTravelDestinationRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(1)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SetTravelDestinationRequest()
		{
			MappinID = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
