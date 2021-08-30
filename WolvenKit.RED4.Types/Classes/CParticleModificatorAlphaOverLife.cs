using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorAlphaOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _alpha;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("alpha")] 
		public CHandle<IEvaluatorFloat> Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		public CParticleModificatorAlphaOverLife()
		{
			_modulate = true;
		}
	}
}
