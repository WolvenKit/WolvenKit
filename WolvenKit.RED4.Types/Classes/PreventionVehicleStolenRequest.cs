using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionVehicleStolenRequest : gameScriptableSystemRequest
	{
		private Vector4 _requesterPosition;
		private CEnum<gamedataAffiliation> _vehicleAffiliation;

		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get => GetProperty(ref _requesterPosition);
			set => SetProperty(ref _requesterPosition, value);
		}

		[Ordinal(1)] 
		[RED("vehicleAffiliation")] 
		public CEnum<gamedataAffiliation> VehicleAffiliation
		{
			get => GetProperty(ref _vehicleAffiliation);
			set => SetProperty(ref _vehicleAffiliation, value);
		}
	}
}
