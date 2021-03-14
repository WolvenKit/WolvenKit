using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BeingTargetByLaserSightUpdateEvent : redEvent
	{
		[Ordinal(0)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<LaserTargettingState> State { get; set; }

		public BeingTargetByLaserSightUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
