using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questToggleBrokenTire_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("tire")] public CUInt32 Tire { get; set; }
		[Ordinal(1)]  [RED("val")] public CBool Val { get; set; }
		[Ordinal(2)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }

		public questToggleBrokenTire_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
