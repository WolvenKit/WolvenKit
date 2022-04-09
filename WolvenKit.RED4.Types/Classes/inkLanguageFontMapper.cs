using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageFontMapper : ISerializable
	{
		[Ordinal(0)] 
		[RED("mappings")] 
		public CArray<inkLanguageFontMapping> Mappings
		{
			get => GetPropertyValue<CArray<inkLanguageFontMapping>>();
			set => SetPropertyValue<CArray<inkLanguageFontMapping>>(value);
		}

		public inkLanguageFontMapper()
		{
			Mappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
