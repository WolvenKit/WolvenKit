using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTypographyResource : CResource
	{
		private CArray<inkLanguageDefinition> _languages;

		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageDefinition> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}
	}
}
