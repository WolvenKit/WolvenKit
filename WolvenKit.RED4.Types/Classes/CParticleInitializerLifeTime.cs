using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerLifeTime : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _lifeTime;

		[Ordinal(4)] 
		[RED("lifeTime")] 
		public CHandle<IEvaluatorFloat> LifeTime
		{
			get => GetProperty(ref _lifeTime);
			set => SetProperty(ref _lifeTime, value);
		}
	}
}
