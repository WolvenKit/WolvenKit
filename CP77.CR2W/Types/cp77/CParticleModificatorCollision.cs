using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		[Ordinal(4)] [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(5)] [RED("dynamicFriction")] public CFloat DynamicFriction { get; set; }
		[Ordinal(6)] [RED("staticFriction")] public CFloat StaticFriction { get; set; }
		[Ordinal(7)] [RED("velocityDamp")] public CFloat VelocityDamp { get; set; }
		[Ordinal(8)] [RED("angularVelocityDamp")] public CFloat AngularVelocityDamp { get; set; }
		[Ordinal(9)] [RED("particleMass")] public CFloat ParticleMass { get; set; }
		[Ordinal(10)] [RED("particleRadius")] public CFloat ParticleRadius { get; set; }
		[Ordinal(11)] [RED("useGPUAcceleration")] public CBool UseGPUAcceleration { get; set; }
		[Ordinal(12)] [RED("disableGravity")] public CBool DisableGravity { get; set; }
		[Ordinal(13)] [RED("killOnCollision")] public CBool KillOnCollision { get; set; }

		public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
