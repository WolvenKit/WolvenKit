using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
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

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
