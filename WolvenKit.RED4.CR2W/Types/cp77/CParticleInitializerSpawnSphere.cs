using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _innerRadius;
		private CHandle<IEvaluatorFloat> _outerRadius;
		private CBool _surfaceOnly;
		private CBool _spawnPositiveX;
		private CBool _spawnNegativeX;
		private CBool _spawnPositiveY;
		private CBool _spawnNegativeY;
		private CBool _spawnPositiveZ;
		private CBool _spawnNegativeZ;
		private CBool _velocity;
		private CBool _worldSpace;
		private CHandle<IEvaluatorFloat> _forceScale;

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
		[RED("spawnPositiveX")] 
		public CBool SpawnPositiveX
		{
			get => GetProperty(ref _spawnPositiveX);
			set => SetProperty(ref _spawnPositiveX, value);
		}

		[Ordinal(8)] 
		[RED("spawnNegativeX")] 
		public CBool SpawnNegativeX
		{
			get => GetProperty(ref _spawnNegativeX);
			set => SetProperty(ref _spawnNegativeX, value);
		}

		[Ordinal(9)] 
		[RED("spawnPositiveY")] 
		public CBool SpawnPositiveY
		{
			get => GetProperty(ref _spawnPositiveY);
			set => SetProperty(ref _spawnPositiveY, value);
		}

		[Ordinal(10)] 
		[RED("spawnNegativeY")] 
		public CBool SpawnNegativeY
		{
			get => GetProperty(ref _spawnNegativeY);
			set => SetProperty(ref _spawnNegativeY, value);
		}

		[Ordinal(11)] 
		[RED("spawnPositiveZ")] 
		public CBool SpawnPositiveZ
		{
			get => GetProperty(ref _spawnPositiveZ);
			set => SetProperty(ref _spawnPositiveZ, value);
		}

		[Ordinal(12)] 
		[RED("spawnNegativeZ")] 
		public CBool SpawnNegativeZ
		{
			get => GetProperty(ref _spawnNegativeZ);
			set => SetProperty(ref _spawnNegativeZ, value);
		}

		[Ordinal(13)] 
		[RED("velocity")] 
		public CBool Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(14)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}

		[Ordinal(15)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetProperty(ref _forceScale);
			set => SetProperty(ref _forceScale, value);
		}

		public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
