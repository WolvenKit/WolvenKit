using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LanguageDropdownListController : DropdownListController
	{
		[Ordinal(8)] 
		[RED("languageItems")] 
		public CArray<CWeakHandle<LanguageDropdownElementController>> LanguageItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<LanguageDropdownElementController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<LanguageDropdownElementController>>>(value);
		}

		public LanguageDropdownListController()
		{
			LanguageItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
