using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MaintenancePanelControllerPS : MasterControllerPS
	{
		[Ordinal(104)]  [RED("maintenancePanelSkillChecks")] public CHandle<EngineeringContainer> MaintenancePanelSkillChecks { get; set; }

		public MaintenancePanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
