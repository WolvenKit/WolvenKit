using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questAssignConvoy_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("Followers")] public CArray<gameEntityReference> Followers { get; set; }
		[Ordinal(1)]  [RED("vehicleLeaderRef")] public gameEntityReference VehicleLeaderRef { get; set; }

		public questAssignConvoy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
