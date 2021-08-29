using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBinkLanguageDescriptor : RedBaseClass
	{
		private CResourceAsyncReference<Bink> _bink;
		private CEnum<inkLanguageId> _languageId;

		[Ordinal(0)] 
		[RED("bink")] 
		public CResourceAsyncReference<Bink> Bink
		{
			get => GetProperty(ref _bink);
			set => SetProperty(ref _bink, value);
		}

		[Ordinal(1)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get => GetProperty(ref _languageId);
			set => SetProperty(ref _languageId, value);
		}
	}
}
