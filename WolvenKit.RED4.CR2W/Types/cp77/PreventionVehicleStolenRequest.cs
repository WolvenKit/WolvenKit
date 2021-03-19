using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionVehicleStolenRequest : gameScriptableSystemRequest
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

		public PreventionVehicleStolenRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
