using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(16)] [RED("typeIcon")] public inkImageWidgetReference TypeIcon { get; set; }
		[Ordinal(17)] [RED("vehicleData")] public CHandle<VehicleListItemData> VehicleData { get; set; }

		public VehiclesManagerListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
