using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorRotationRateOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _rotationRate;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get => GetProperty(ref _rotationRate);
			set => SetProperty(ref _rotationRate, value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}
	}
}
