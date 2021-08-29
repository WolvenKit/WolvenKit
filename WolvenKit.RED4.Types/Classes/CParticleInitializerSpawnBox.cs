using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerSpawnBox : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _extents;
		private CBool _worldSpace;
		private CBool _surfaceOnly;

		[Ordinal(4)] 
		[RED("extents")] 
		public CHandle<IEvaluatorVector> Extents
		{
			get => GetProperty(ref _extents);
			set => SetProperty(ref _extents, value);
		}

		[Ordinal(5)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}

		[Ordinal(6)] 
		[RED("surfaceOnly")] 
		public CBool SurfaceOnly
		{
			get => GetProperty(ref _surfaceOnly);
			set => SetProperty(ref _surfaceOnly, value);
		}
	}
}
