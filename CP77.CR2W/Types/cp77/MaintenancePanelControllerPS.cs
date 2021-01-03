using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MaintenancePanelControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("maintenancePanelSkillChecks")] public CHandle<EngineeringContainer> MaintenancePanelSkillChecks { get; set; }

		public MaintenancePanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
