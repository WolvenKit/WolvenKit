using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElectricLightControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isConnectedToCLS")] public CBool IsConnectedToCLS { get; set; }
		[Ordinal(104)] [RED("wasCLSInitTriggered")] public CBool WasCLSInitTriggered { get; set; }

		public ElectricLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
