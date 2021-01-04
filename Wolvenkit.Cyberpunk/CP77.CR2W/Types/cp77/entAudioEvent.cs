using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAudioEvent : redEvent
	{
		[Ordinal(0)]  [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(1)]  [RED("eventFlags")] public CEnum<audioAudioEventFlags> EventFlags { get; set; }
		[Ordinal(2)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(3)]  [RED("eventType")] public CEnum<audioEventActionType> EventType { get; set; }
		[Ordinal(4)]  [RED("floatData")] public CFloat FloatData { get; set; }
		[Ordinal(5)]  [RED("nameData")] public CName NameData { get; set; }

		public entAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
