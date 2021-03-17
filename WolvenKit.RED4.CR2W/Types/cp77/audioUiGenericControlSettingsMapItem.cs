using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiGenericControlSettingsMapItem : audioAudioMetadata
	{
		private CHandle<audioKeySoundEventDictionary> _uiEventToAudioEventDictionary;

		[Ordinal(1)] 
		[RED("uiEventToAudioEventDictionary")] 
		public CHandle<audioKeySoundEventDictionary> UiEventToAudioEventDictionary
		{
			get => GetProperty(ref _uiEventToAudioEventDictionary);
			set => SetProperty(ref _uiEventToAudioEventDictionary, value);
		}

		public audioUiGenericControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
