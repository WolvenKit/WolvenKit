using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioUiGenericControlSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("uiEventToAudioEventDictionary")] public CHandle<audioKeySoundEventDictionary> UiEventToAudioEventDictionary { get; set; }

		public audioUiGenericControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
