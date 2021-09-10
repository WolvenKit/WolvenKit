using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLanguageGameConfiguration : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("langsInProject")] 
		public CArray<audioLanguageMapItem> LangsInProject
		{
			get => GetPropertyValue<CArray<audioLanguageMapItem>>();
			set => SetPropertyValue<CArray<audioLanguageMapItem>>(value);
		}

		public audioLanguageGameConfiguration()
		{
			LangsInProject = new();
		}
	}
}
