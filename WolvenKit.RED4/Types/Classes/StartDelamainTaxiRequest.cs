using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartDelamainTaxiRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public StartDelamainTaxiRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
