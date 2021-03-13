using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleHealthStatPoolListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<vehicleBaseObject> Owner { get; set; }

		public VehicleHealthStatPoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
