using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(3)] [RED("params")] public questTeleportPuppetParams Params { get; set; }
		[Ordinal(4)] [RED("resetVelocities")] public CBool ResetVelocities { get; set; }

		public questTeleportVehicleNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
