using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAutoFoliageMappingItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("LayerIndex")] 
		public CUInt32 LayerIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("FoliageBrush")] 
		public CResourceAsyncReference<worldFoliageBrush> FoliageBrush
		{
			get => GetPropertyValue<CResourceAsyncReference<worldFoliageBrush>>();
			set => SetPropertyValue<CResourceAsyncReference<worldFoliageBrush>>(value);
		}

		public worldAutoFoliageMappingItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
