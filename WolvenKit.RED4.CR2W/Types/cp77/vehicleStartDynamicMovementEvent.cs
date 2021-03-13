using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleStartDynamicMovementEvent : redEvent
	{
		[Ordinal(0)] [RED("targetPosition")] public Vector3 TargetPosition { get; set; }

		public vehicleStartDynamicMovementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
