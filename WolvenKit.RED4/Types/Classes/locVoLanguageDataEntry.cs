using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoLanguageDataEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("voiceverMapReport")] 
		public CResourceAsyncReference<JsonResource> VoiceverMapReport
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		[Ordinal(2)] 
		[RED("lengthMapReport")] 
		public CResourceAsyncReference<JsonResource> LengthMapReport
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		[Ordinal(3)] 
		[RED("voMapChunks")] 
		public CArray<CResourceAsyncReference<JsonResource>> VoMapChunks
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<JsonResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<JsonResource>>>(value);
		}

		public locVoLanguageDataEntry()
		{
			VoMapChunks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
