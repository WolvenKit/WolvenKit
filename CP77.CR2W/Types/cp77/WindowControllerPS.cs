using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WindowControllerPS : DoorControllerPS
	{
		[Ordinal(0)]  [RED("windowSkillChecks")] public CHandle<EngDemoContainer> WindowSkillChecks { get; set; }

		public WindowControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
