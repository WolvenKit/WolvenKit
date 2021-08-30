using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerSize : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _size;
		private CFloat _scale;

		[Ordinal(4)] 
		[RED("size")] 
		public CHandle<IEvaluatorVector> Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		public CParticleInitializerSize()
		{
			_scale = 1.000000F;
		}
	}
}
