using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEnablePlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("vehicle")] public CString Vehicle { get; set; }
		[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)] [RED("despawn")] public CBool Despawn { get; set; }
		[Ordinal(3)] [RED("makePlayerActiveVehicle")] public CBool MakePlayerActiveVehicle { get; set; }

		public questEnablePlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
