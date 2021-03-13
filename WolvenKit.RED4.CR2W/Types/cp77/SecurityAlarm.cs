using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarm : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("workingAlarm")] public CHandle<entMeshComponent> WorkingAlarm { get; set; }
		[Ordinal(94)] [RED("destroyedAlarm")] public CHandle<entMeshComponent> DestroyedAlarm { get; set; }
		[Ordinal(95)] [RED("isGlitching")] public CBool IsGlitching { get; set; }

		public SecurityAlarm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
