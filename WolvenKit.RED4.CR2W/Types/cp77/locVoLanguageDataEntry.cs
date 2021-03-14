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
			get
			{
				if (_languageCode == null)
				{
					_languageCode = (CName) CR2WTypeManager.Create("CName", "languageCode", cr2w, this);
				}
				return _languageCode;
			}
			set
			{
				if (_languageCode == value)
				{
					return;
				}
				_languageCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voiceverMapReport")] 
		public raRef<JsonResource> VoiceverMapReport
		{
			get
			{
				if (_voiceverMapReport == null)
				{
					_voiceverMapReport = (raRef<JsonResource>) CR2WTypeManager.Create("raRef:JsonResource", "voiceverMapReport", cr2w, this);
				}
				return _voiceverMapReport;
			}
			set
			{
				if (_voiceverMapReport == value)
				{
					return;
				}
				_voiceverMapReport = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lenghtMapReport")] 
		public raRef<JsonResource> LenghtMapReport
		{
			get
			{
				if (_lenghtMapReport == null)
				{
					_lenghtMapReport = (raRef<JsonResource>) CR2WTypeManager.Create("raRef:JsonResource", "lenghtMapReport", cr2w, this);
				}
				return _lenghtMapReport;
			}
			set
			{
				if (_lenghtMapReport == value)
				{
					return;
				}
				_lenghtMapReport = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("voMapChunks")] 
		public CArray<raRef<JsonResource>> VoMapChunks
		{
			get
			{
				if (_voMapChunks == null)
				{
					_voMapChunks = (CArray<raRef<JsonResource>>) CR2WTypeManager.Create("array:raRef:JsonResource", "voMapChunks", cr2w, this);
				}
				return _voMapChunks;
			}
			set
			{
				if (_voMapChunks == value)
				{
					return;
				}
				_voMapChunks = value;
				PropertySet(this);
			}
		}

		public locVoLanguageDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
