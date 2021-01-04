using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("weakFenceSetup")] public WeakFenceSetup WeakFenceSetup { get; set; }
		[Ordinal(1)]  [RED("weakfenceSkillChecks")] public CHandle<EngDemoContainer> WeakfenceSkillChecks { get; set; }

		public WeakFenceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
