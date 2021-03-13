using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityArea : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("area")] public CHandle<gameStaticTriggerAreaComponent> Area { get; set; }

		public SecurityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
