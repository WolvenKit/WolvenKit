using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleListItemData : IScriptable
	{
		[Ordinal(0)]  [RED("data")] public vehiclePlayerVehicle Data { get; set; }
		[Ordinal(1)]  [RED("displayName")] public CName DisplayName { get; set; }
		[Ordinal(2)]  [RED("icon")] public wCHandle<gamedataUIIcon_Record> Icon { get; set; }

		public VehicleListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
