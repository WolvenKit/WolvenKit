using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioUiControlEventsSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("baseEvent")] public CName BaseEvent { get; set; }
		[Ordinal(2)] [RED("customActionsDictionary")] public CHandle<audioKeySoundEventDictionary> CustomActionsDictionary { get; set; }

		public audioUiControlEventsSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
