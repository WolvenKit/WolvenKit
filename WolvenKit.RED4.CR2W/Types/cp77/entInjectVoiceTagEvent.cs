using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entInjectVoiceTagEvent : redEvent
	{
		[Ordinal(0)] [RED("voiceTagName")] public CName VoiceTagName { get; set; }
		[Ordinal(1)] [RED("forceInjection")] public CBool ForceInjection { get; set; }

		public entInjectVoiceTagEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
