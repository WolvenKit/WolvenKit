using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_Setup : CResource
	{
		private CArray<Multilayer_Layer> _layers;
		private CFloat _ratio;
		private CBool _useNormal;

		[Ordinal(1)] 
		[RED("layers")] 
		public CArray<Multilayer_Layer> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		[Ordinal(2)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get => GetProperty(ref _ratio);
			set => SetProperty(ref _ratio, value);
		}

		[Ordinal(3)] 
		[RED("useNormal")] 
		public CBool UseNormal
		{
			get => GetProperty(ref _useNormal);
			set => SetProperty(ref _useNormal, value);
		}

		public Multilayer_Setup()
		{
			_ratio = 1.000000F;
			_useNormal = true;
		}
	}
}
