using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAutoFoliageMapping : CResource
	{
		[Ordinal(1)] 
		[RED("Items")] 
		public CArray<worldAutoFoliageMappingItem> Items
		{
			get => GetPropertyValue<CArray<worldAutoFoliageMappingItem>>();
			set => SetPropertyValue<CArray<worldAutoFoliageMappingItem>>(value);
		}

		public worldAutoFoliageMapping()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
