using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAutoFoliageMappingItem : RedBaseClass
	{
		private CName _material;
		private CUInt32 _layerIndex;
		private CResourceAsyncReference<worldFoliageBrush> _foliageBrush;

		[Ordinal(0)] 
		[RED("Material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(1)] 
		[RED("LayerIndex")] 
		public CUInt32 LayerIndex
		{
			get => GetProperty(ref _layerIndex);
			set => SetProperty(ref _layerIndex, value);
		}

		[Ordinal(2)] 
		[RED("FoliageBrush")] 
		public CResourceAsyncReference<worldFoliageBrush> FoliageBrush
		{
			get => GetProperty(ref _foliageBrush);
			set => SetProperty(ref _foliageBrush, value);
		}
	}
}
