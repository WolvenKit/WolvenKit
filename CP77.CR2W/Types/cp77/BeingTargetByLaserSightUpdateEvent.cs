using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BeingTargetByLaserSightUpdateEvent : redEvent
	{
		[Ordinal(0)]  [RED("state")] public CEnum<LaserTargettingState> State { get; set; }
		[Ordinal(1)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public BeingTargetByLaserSightUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
