using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlockTrap : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }

		public RoadBlockTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
