using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageOverrideProvider : inkUserData
	{
		private CEnum<inkLanguageId> _languageId;

		[Ordinal(0)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get => GetProperty(ref _languageId);
			set => SetProperty(ref _languageId, value);
		}
	}
}
