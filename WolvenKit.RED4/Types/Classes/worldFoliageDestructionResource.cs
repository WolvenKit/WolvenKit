using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageDestructionResource : CResource
	{
		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<CHandle<worldFoliageDestructionMapping>> Mappings
		{
			get => GetPropertyValue<CArray<CHandle<worldFoliageDestructionMapping>>>();
			set => SetPropertyValue<CArray<CHandle<worldFoliageDestructionMapping>>>(value);
		}

		public worldFoliageDestructionResource()
		{
			Mappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
