using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionVehicleStolenRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requesterPosition")] public Vector4 RequesterPosition { get; set; }
		[Ordinal(1)] [RED("vehicleAffiliation")] public CEnum<gamedataAffiliation> VehicleAffiliation { get; set; }

		public PreventionVehicleStolenRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
