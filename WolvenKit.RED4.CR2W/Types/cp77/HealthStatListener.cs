using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("ownerPuppet")] public wCHandle<PlayerPuppet> OwnerPuppet { get; set; }
		[Ordinal(1)] [RED("healthEvent")] public CHandle<HealthUpdateEvent> HealthEvent { get; set; }

		public HealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
