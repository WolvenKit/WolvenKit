using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RegisterVehicleRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public RegisterVehicleRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
