using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaySoundEvent : inkanimEvent
	{
		[Ordinal(0)]  [RED("soundEventName")] public CName SoundEventName { get; set; }

		public inkanimPlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
