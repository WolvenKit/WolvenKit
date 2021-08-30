using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorSizeOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _size;
		private CFloat _scale;
		private CBool _modulate;

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

		[Ordinal(6)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		public CParticleModificatorSizeOverLife()
		{
			_scale = 1.000000F;
			_modulate = true;
		}
	}
}
