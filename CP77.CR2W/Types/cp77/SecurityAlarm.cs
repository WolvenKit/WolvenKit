using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarm : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("destroyedAlarm")] public CHandle<entMeshComponent> DestroyedAlarm { get; set; }
		[Ordinal(1)]  [RED("isGlitching")] public CBool IsGlitching { get; set; }
		[Ordinal(2)]  [RED("workingAlarm")] public CHandle<entMeshComponent> WorkingAlarm { get; set; }

		public SecurityAlarm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
