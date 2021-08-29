using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLanguageGameConfiguration : audioAudioMetadata
	{
		private CArray<audioLanguageMapItem> _langsInProject;

		[Ordinal(1)] 
		[RED("langsInProject")] 
		public CArray<audioLanguageMapItem> LangsInProject
		{
			get => GetProperty(ref _langsInProject);
			set => SetProperty(ref _langsInProject, value);
		}
	}
}
