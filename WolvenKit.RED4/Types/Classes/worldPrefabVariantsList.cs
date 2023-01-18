using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPrefabVariantsList : ISerializable
	{
		[Ordinal(0)] 
		[RED("activeVariants")] 
		public CArray<CName> ActiveVariants
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public worldPrefabVariantsList()
		{
			ActiveVariants = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
