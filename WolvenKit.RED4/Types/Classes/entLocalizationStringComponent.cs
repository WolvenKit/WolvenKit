using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLocalizationStringComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("Strings")] 
		public CArray<entLocalizationStringMapEntry> Strings
		{
			get => GetPropertyValue<CArray<entLocalizationStringMapEntry>>();
			set => SetPropertyValue<CArray<entLocalizationStringMapEntry>>(value);
		}

		public entLocalizationStringComponent()
		{
			Name = "Component";
			Strings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
