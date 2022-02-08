using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerLifeTime : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("lifeTime")] 
		public CHandle<IEvaluatorFloat> LifeTime
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerLifeTime()
		{
			EditorName = "Life time";
			EditorGroup = "Default";
			IsEnabled = true;
		}
	}
}
