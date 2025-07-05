using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageRawData : ISerializable
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageRawItem>> Items
		{
			get => GetPropertyValue<CArray<CHandle<worldFoliageRawItem>>>();
			set => SetPropertyValue<CArray<CHandle<worldFoliageRawItem>>>(value);
		}

		public worldFoliageRawData()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
