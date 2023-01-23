using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionVehicleStolenRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleAffiliation")] 
		public CEnum<gamedataAffiliation> VehicleAffiliation
		{
			get => GetPropertyValue<CEnum<gamedataAffiliation>>();
			set => SetPropertyValue<CEnum<gamedataAffiliation>>(value);
		}

		public PreventionVehicleStolenRequest()
		{
			RequesterPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
