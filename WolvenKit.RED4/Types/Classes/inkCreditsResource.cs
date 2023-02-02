using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCreditsResource : CResource
	{
		[Ordinal(1)] 
		[RED("sections")] 
		public CArray<inkCreditsSectionEntry> Sections
		{
			get => GetPropertyValue<CArray<inkCreditsSectionEntry>>();
			set => SetPropertyValue<CArray<inkCreditsSectionEntry>>(value);
		}

		public inkCreditsResource()
		{
			Sections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
