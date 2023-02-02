using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAppearanceToNPCMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("foleyNPCMetadata")] 
		public CName FoleyNPCMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAppearanceToNPCMetadata()
		{
			Appearances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
