using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsPlaySoundOnEmitter : gameaudioeventsEmitterEvent
	{
		[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }

		public gameaudioeventsPlaySoundOnEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
