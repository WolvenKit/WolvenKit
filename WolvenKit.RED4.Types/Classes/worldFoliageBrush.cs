using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageBrush : CResource
	{
		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageBrushItem>> Items
		{
			get => GetPropertyValue<CArray<CHandle<worldFoliageBrushItem>>>();
			set => SetPropertyValue<CArray<CHandle<worldFoliageBrushItem>>>(value);
		}

		public worldFoliageBrush()
		{
			Items = new() { null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
