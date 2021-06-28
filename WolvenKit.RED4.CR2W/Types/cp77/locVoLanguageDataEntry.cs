using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoLanguageDataEntry : CVariable
	{
		private CName _languageCode;
		private raRef<JsonResource> _voiceverMapReport;
		private raRef<JsonResource> _lenghtMapReport;
		private CArray<raRef<JsonResource>> _voMapChunks;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetProperty(ref _languageCode);
			set => SetProperty(ref _languageCode, value);
		}

		[Ordinal(1)] 
		[RED("voiceverMapReport")] 
		public raRef<JsonResource> VoiceverMapReport
		{
			get => GetProperty(ref _voiceverMapReport);
			set => SetProperty(ref _voiceverMapReport, value);
		}

		[Ordinal(2)] 
		[RED("lenghtMapReport")] 
		public raRef<JsonResource> LenghtMapReport
		{
			get => GetProperty(ref _lenghtMapReport);
			set => SetProperty(ref _lenghtMapReport, value);
		}

		[Ordinal(3)] 
		[RED("voMapChunks")] 
		public CArray<raRef<JsonResource>> VoMapChunks
		{
			get => GetProperty(ref _voMapChunks);
			set => SetProperty(ref _voMapChunks, value);
		}

		public locVoLanguageDataEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
