using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("chestPressSkillChecks")] public CHandle<EngDemoContainer> ChestPressSkillChecks { get; set; }
		[Ordinal(1)]  [RED("factOnQHack")] public CName FactOnQHack { get; set; }
		[Ordinal(2)]  [RED("wasWeighHacked")] public CBool WasWeighHacked { get; set; }

		public ChestPressControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
