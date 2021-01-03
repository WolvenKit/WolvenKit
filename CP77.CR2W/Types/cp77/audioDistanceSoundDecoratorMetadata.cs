using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDistanceSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("onEnter")] public CName OnEnter { get; set; }
		[Ordinal(1)]  [RED("onLeave")] public CName OnLeave { get; set; }
		[Ordinal(2)]  [RED("stopOnlyVirtualSounds")] public CBool StopOnlyVirtualSounds { get; set; }
		[Ordinal(3)]  [RED("triggerDistance")] public CFloat TriggerDistance { get; set; }

		public audioDistanceSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
