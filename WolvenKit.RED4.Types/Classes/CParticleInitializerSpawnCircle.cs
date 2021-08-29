using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _innerRadius;
		private CHandle<IEvaluatorFloat> _outerRadius;
		private CBool _surfaceOnly;
		private CBool _worldSpace;
		private CMatrix _spawnToLocal;

		[Ordinal(4)] 
		[RED("innerRadius")] 
		public CHandle<IEvaluatorFloat> InnerRadius
		{
			get => GetProperty(ref _innerRadius);
			set => SetProperty(ref _innerRadius, value);
		}

		[Ordinal(5)] 
		[RED("outerRadius")] 
		public CHandle<IEvaluatorFloat> OuterRadius
		{
			get => GetProperty(ref _outerRadius);
			set => SetProperty(ref _outerRadius, value);
		}

		[Ordinal(6)] 
		[RED("surfaceOnly")] 
		public CBool SurfaceOnly
		{
			get => GetProperty(ref _surfaceOnly);
			set => SetProperty(ref _surfaceOnly, value);
		}

		[Ordinal(7)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}

		[Ordinal(8)] 
		[RED("spawnToLocal")] 
		public CMatrix SpawnToLocal
		{
			get => GetProperty(ref _spawnToLocal);
			set => SetProperty(ref _spawnToLocal, value);
		}
	}
}
