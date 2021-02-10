using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)]  [RED("MovableDeviceSetup")] public MovableDeviceSetup MovableDeviceSetup { get; set; }
		[Ordinal(104)]  [RED("movableDeviceSkillChecks")] public CHandle<DemolitionContainer> MovableDeviceSkillChecks { get; set; }

		public MovableDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
