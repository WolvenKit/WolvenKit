using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiControlMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("uiControlsByName")] 
		public CHandle<audioKeyUiControlDictionary> UiControlsByName
		{
			get => GetPropertyValue<CHandle<audioKeyUiControlDictionary>>();
			set => SetPropertyValue<CHandle<audioKeyUiControlDictionary>>(value);
		}
	}
}
