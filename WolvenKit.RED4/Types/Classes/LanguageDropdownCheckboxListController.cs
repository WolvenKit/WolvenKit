using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LanguageDropdownCheckboxListController : DropdownListController
	{
		[Ordinal(8)] 
		[RED("languageItems")] 
		public CArray<CWeakHandle<LanguageDropdownCheckboxElementController>> LanguageItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<LanguageDropdownCheckboxElementController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<LanguageDropdownCheckboxElementController>>>(value);
		}

		public LanguageDropdownCheckboxListController()
		{
			LanguageItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
