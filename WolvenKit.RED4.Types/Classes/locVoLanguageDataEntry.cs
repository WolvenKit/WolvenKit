using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoLanguageDataEntry : RedBaseClass
	{
		private CName _languageCode;
		private CResourceAsyncReference<JsonResource> _voiceverMapReport;
		private CResourceAsyncReference<JsonResource> _lenghtMapReport;
		private CArray<CResourceAsyncReference<JsonResource>> _voMapChunks;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetProperty(ref _languageCode);
			set => SetProperty(ref _languageCode, value);
		}

		[Ordinal(1)] 
		[RED("voiceverMapReport")] 
		public CResourceAsyncReference<JsonResource> VoiceverMapReport
		{
			get => GetProperty(ref _voiceverMapReport);
			set => SetProperty(ref _voiceverMapReport, value);
		}

		[Ordinal(2)] 
		[RED("lenghtMapReport")] 
		public CResourceAsyncReference<JsonResource> LenghtMapReport
		{
			get => GetProperty(ref _lenghtMapReport);
			set => SetProperty(ref _lenghtMapReport, value);
		}

		[Ordinal(3)] 
		[RED("voMapChunks")] 
		public CArray<CResourceAsyncReference<JsonResource>> VoMapChunks
		{
			get => GetProperty(ref _voMapChunks);
			set => SetProperty(ref _voMapChunks, value);
		}
	}
}
