using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleNodeCommandDefinition : questAICommandNodeBase
	{
		[Ordinal(0)]  [RED("commandParams")] public CHandle<questVehicleCommandParams> CommandParams { get; set; }
		[Ordinal(1)]  [RED("vehicle")] public gameEntityReference Vehicle { get; set; }

		public questVehicleNodeCommandDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
