using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeTrackerTargetAcquiredEvent : redEvent
	{
		[Ordinal(0)] [RED("target")] public wCHandle<ScriptedPuppet> Target { get; set; }
		[Ordinal(1)] [RED("targetSlot")] public CName TargetSlot { get; set; }

		public GrenadeTrackerTargetAcquiredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
