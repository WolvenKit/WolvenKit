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
			get => GetProperty(ref _uiEventSettingsMatrix);
			set => SetProperty(ref _uiEventSettingsMatrix, value);
		}

		public audioUiSpecificControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
