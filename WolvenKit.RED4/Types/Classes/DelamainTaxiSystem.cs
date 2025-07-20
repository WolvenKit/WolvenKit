using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelamainTaxiSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("isDelamainTaxiEnabledOnMap")] 
		public CBool IsDelamainTaxiEnabledOnMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("delamainMappinID")] 
		public gameNewMappinID DelamainMappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(2)] 
		[RED("currentTravelCost")] 
		public CInt32 CurrentTravelCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("HUDHidden")] 
		public CBool HUDHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("delamainTaxi")] 
		public CWeakHandle<DelamainTaxiComponent> DelamainTaxi
		{
			get => GetPropertyValue<CWeakHandle<DelamainTaxiComponent>>();
			set => SetPropertyValue<CWeakHandle<DelamainTaxiComponent>>(value);
		}

		public DelamainTaxiSystem()
		{
			DelamainMappinID = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
