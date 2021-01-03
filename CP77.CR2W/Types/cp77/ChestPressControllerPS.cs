using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
