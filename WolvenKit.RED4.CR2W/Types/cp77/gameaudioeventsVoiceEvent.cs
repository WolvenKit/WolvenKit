using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsVoiceEvent : redEvent
	{
		[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)] [RED("gruntType")] public CEnum<audioVoGruntType> GruntType { get; set; }
		[Ordinal(2)] [RED("gruntInterruptMode")] public CEnum<audioVoGruntInterruptMode> GruntInterruptMode { get; set; }
		[Ordinal(3)] [RED("isV")] public CBool IsV { get; set; }

		public gameaudioeventsVoiceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
