using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleSystem : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("prewarmingTime")] 
		public CFloat PrewarmingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("emitters")] 
		public CArray<CHandle<CParticleEmitter>> Emitters
		{
			get => GetPropertyValue<CArray<CHandle<CParticleEmitter>>>();
			set => SetPropertyValue<CArray<CHandle<CParticleEmitter>>>(value);
		}

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lastLODFadeoutRange")] 
		public CFloat LastLODFadeoutRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetPropertyValue<CEnum<ERenderingPlane>>();
			set => SetPropertyValue<CEnum<ERenderingPlane>>(value);
		}

		[Ordinal(9)] 
		[RED("particleDamage")] 
		public CHandle<ParticleDamage> ParticleDamage
		{
			get => GetPropertyValue<CHandle<ParticleDamage>>();
			set => SetPropertyValue<CHandle<ParticleDamage>>(value);
		}

		public CParticleSystem()
		{
			Emitters = new();
			BoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };
			AutoHideDistance = 100.000000F;
			LastLODFadeoutRange = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
