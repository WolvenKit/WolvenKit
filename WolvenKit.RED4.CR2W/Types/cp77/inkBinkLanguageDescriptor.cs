using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBinkLanguageDescriptor : CVariable
	{
		private raRef<Bink> _bink;
		private CEnum<inkLanguageId> _languageId;

		[Ordinal(0)] 
		[RED("bink")] 
		public raRef<Bink> Bink
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

		public inkBinkLanguageDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
