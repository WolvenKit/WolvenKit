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
			get
			{
				if (_uiEventToAudioEventDictionary == null)
				{
					_uiEventToAudioEventDictionary = (CHandle<audioKeySoundEventDictionary>) CR2WTypeManager.Create("handle:audioKeySoundEventDictionary", "uiEventToAudioEventDictionary", cr2w, this);
				}
				return _uiEventToAudioEventDictionary;
			}
			set
			{
				if (_uiEventToAudioEventDictionary == value)
				{
					return;
				}
				_uiEventToAudioEventDictionary = value;
				PropertySet(this);
			}
		}

		public audioUiGenericControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
