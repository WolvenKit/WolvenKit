using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _scale;
		private CBool _conserveMomentum;

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(5)] 
		[RED("conserveMomentum")] 
		public CBool ConserveMomentum
		{
			get => GetProperty(ref _conserveMomentum);
			set => SetProperty(ref _conserveMomentum, value);
		}

		public CParticleInitializerVelocitySpread()
		{
			_conserveMomentum = true;
		}
	}
}
