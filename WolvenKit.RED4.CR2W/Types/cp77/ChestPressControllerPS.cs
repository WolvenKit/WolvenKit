using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("chestPressSkillChecks")] public CHandle<EngDemoContainer> ChestPressSkillChecks { get; set; }
		[Ordinal(104)] [RED("factOnQHack")] public CName FactOnQHack { get; set; }
		[Ordinal(105)] [RED("wasWeighHacked")] public CBool WasWeighHacked { get; set; }

		public ChestPressControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
