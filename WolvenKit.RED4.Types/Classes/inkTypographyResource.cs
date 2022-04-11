using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTypographyResource : CResource
	{
		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageDefinition> Languages
		{
			get => GetPropertyValue<CArray<inkLanguageDefinition>>();
			set => SetPropertyValue<CArray<inkLanguageDefinition>>(value);
		}

		public inkTypographyResource()
		{
			Languages = new() { new() { LanguageCode = "en-us", IsoScriptCode = "Latn", Fonts = new() { new() } } };
		}
	}
}
