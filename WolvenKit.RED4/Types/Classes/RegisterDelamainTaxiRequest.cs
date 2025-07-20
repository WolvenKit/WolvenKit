using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterDelamainTaxiRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("delamainTaxi")] 
		public CWeakHandle<DelamainTaxiComponent> DelamainTaxi
		{
			get => GetPropertyValue<CWeakHandle<DelamainTaxiComponent>>();
			set => SetPropertyValue<CWeakHandle<DelamainTaxiComponent>>(value);
		}

		public RegisterDelamainTaxiRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
