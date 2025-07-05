using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntityAppearanceColorVariantsArray : ISerializable
	{
		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("colorVariants")] 
		public CArray<CName> ColorVariants
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameEntityAppearanceColorVariantsArray()
		{
			ColorVariants = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
