using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiControlEventsSettingsMapItem : audioAudioMetadata
	{
		private CName _baseEvent;
		private CHandle<audioKeySoundEventDictionary> _customActionsDictionary;

		[Ordinal(1)] 
		[RED("baseEvent")] 
		public CName BaseEvent
		{
			get
			{
				if (_baseEvent == null)
				{
					_baseEvent = (CName) CR2WTypeManager.Create("CName", "baseEvent", cr2w, this);
				}
				return _baseEvent;
			}
			set
			{
				if (_baseEvent == value)
				{
					return;
				}
				_baseEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("customActionsDictionary")] 
		public CHandle<audioKeySoundEventDictionary> CustomActionsDictionary
		{
			get
			{
				if (_customActionsDictionary == null)
				{
					_customActionsDictionary = (CHandle<audioKeySoundEventDictionary>) CR2WTypeManager.Create("handle:audioKeySoundEventDictionary", "customActionsDictionary", cr2w, this);
				}
				return _customActionsDictionary;
			}
			set
			{
				if (_customActionsDictionary == value)
				{
					return;
				}
				_customActionsDictionary = value;
				PropertySet(this);
			}
		}

		public audioUiControlEventsSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
