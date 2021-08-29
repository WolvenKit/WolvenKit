using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiControlMap : audioAudioMetadata
	{
		private CHandle<audioKeyUiControlDictionary> _uiControlsByName;

		[Ordinal(1)] 
		[RED("uiControlsByName")] 
		public CHandle<audioKeyUiControlDictionary> UiControlsByName
		{
			get => GetProperty(ref _uiControlsByName);
			set => SetProperty(ref _uiControlsByName, value);
		}
	}
}
