using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FrozenFrame : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("maxFramesFrozen")] public CInt32 MaxFramesFrozen { get; set; }
		[Ordinal(13)] [RED("triggerEventName")] public CName TriggerEventName { get; set; }
		[Ordinal(14)] [RED("clearEventName")] public CName ClearEventName { get; set; }

		public animAnimNode_FrozenFrame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
