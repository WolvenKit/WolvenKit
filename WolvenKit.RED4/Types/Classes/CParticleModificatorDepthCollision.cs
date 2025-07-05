using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorDepthCollision : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("maxCollisions")] 
		public CUInt32 MaxCollisions
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("collisionEffect")] 
		public CEnum<EDepthCollisionEffect> CollisionEffect
		{
			get => GetPropertyValue<CEnum<EDepthCollisionEffect>>();
			set => SetPropertyValue<CEnum<EDepthCollisionEffect>>(value);
		}

		public CParticleModificatorDepthCollision()
		{
			EditorName = "Depth Collision";
			EditorGroup = "Physics";
			IsEnabled = true;
			MaxCollisions = 8;
			Restitution = 0.700000F;
			Friction = 1.000000F;
			Radius = 0.010000F;
			CollisionEffect = Enums.EDepthCollisionEffect.DCE_Bounce;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
