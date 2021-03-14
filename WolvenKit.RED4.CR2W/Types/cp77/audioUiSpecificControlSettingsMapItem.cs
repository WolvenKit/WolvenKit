using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMapItem : audioAudioMetadata
	{
		private CArray<audioUiControlEventsSettingsMapItem> _uiEventSettingsMatrix;

		[Ordinal(1)] 
		[RED("uiEventSettingsMatrix")] 
		public CArray<audioUiControlEventsSettingsMapItem> UiEventSettingsMatrix
		{
			get
			{
				if (_uiEventSettingsMatrix == null)
				{
					_uiEventSettingsMatrix = (CArray<audioUiControlEventsSettingsMapItem>) CR2WTypeManager.Create("array:audioUiControlEventsSettingsMapItem", "uiEventSettingsMatrix", cr2w, this);
				}
				return _uiEventSettingsMatrix;
			}
			set
			{
				if (_uiEventSettingsMatrix == value)
				{
					return;
				}
				_uiEventSettingsMatrix = value;
				PropertySet(this);
			}
		}

		public audioUiSpecificControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
