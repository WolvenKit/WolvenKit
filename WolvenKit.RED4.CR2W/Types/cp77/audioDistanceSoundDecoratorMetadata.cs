using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDistanceSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("onEnter")] public CName OnEnter { get; set; }
		[Ordinal(2)] [RED("onLeave")] public CName OnLeave { get; set; }
		[Ordinal(3)] [RED("triggerDistance")] public CFloat TriggerDistance { get; set; }
		[Ordinal(4)] [RED("stopOnlyVirtualSounds")] public CBool StopOnlyVirtualSounds { get; set; }

		public audioDistanceSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
