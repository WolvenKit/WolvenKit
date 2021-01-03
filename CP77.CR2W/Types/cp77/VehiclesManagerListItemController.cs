using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("typeIcon")] public inkImageWidgetReference TypeIcon { get; set; }
		[Ordinal(2)]  [RED("vehicleData")] public CHandle<VehicleListItemData> VehicleData { get; set; }

		public VehiclesManagerListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
