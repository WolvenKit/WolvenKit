using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entParticlesComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("particleSystem")] 
		public CResourceReference<CParticleSystem> ParticleSystem
		{
			get => GetPropertyValue<CResourceReference<CParticleSystem>>();
			set => SetPropertyValue<CResourceReference<CParticleSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("renderLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entParticlesComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			EmissionRate = 1.000000F;
			RenderLayerMask = Enums.RenderSceneLayerMask.Default;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
