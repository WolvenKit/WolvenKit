using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageOverrideProvider : inkUserData
	{
		private CEnum<inkLanguageId> _languageId;

		[Ordinal(0)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get => GetProperty(ref _languageId);
			set => SetProperty(ref _languageId, value);
		}

		public inkLanguageOverrideProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
