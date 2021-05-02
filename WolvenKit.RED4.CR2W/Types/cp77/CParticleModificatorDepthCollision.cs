using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDepthCollision : IParticleModificator
	{
		private CUInt32 _maxCollisions;
		private CFloat _restitution;
		private CFloat _friction;
		private CFloat _radius;
		private CEnum<EDepthCollisionEffect> _collisionEffect;

		[Ordinal(4)] 
		[RED("maxCollisions")] 
		public CUInt32 MaxCollisions
		{
			get => GetProperty(ref _maxCollisions);
			set => SetProperty(ref _maxCollisions, value);
		}

		[Ordinal(5)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetProperty(ref _restitution);
			set => SetProperty(ref _restitution, value);
		}

		[Ordinal(6)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get => GetProperty(ref _friction);
			set => SetProperty(ref _friction, value);
		}

		[Ordinal(7)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(8)] 
		[RED("collisionEffect")] 
		public CEnum<EDepthCollisionEffect> CollisionEffect
		{
			get => GetProperty(ref _collisionEffect);
			set => SetProperty(ref _collisionEffect, value);
		}

		public CParticleModificatorDepthCollision(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
