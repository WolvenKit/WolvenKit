using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		[Ordinal(0)]  [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(1)]  [RED("dynamicFriction")] public CFloat DynamicFriction { get; set; }
		[Ordinal(2)]  [RED("staticFriction")] public CFloat StaticFriction { get; set; }
		[Ordinal(3)]  [RED("velocityDamp")] public CFloat VelocityDamp { get; set; }
		[Ordinal(4)]  [RED("angularVelocityDamp")] public CFloat AngularVelocityDamp { get; set; }
		[Ordinal(5)]  [RED("particleMass")] public CFloat ParticleMass { get; set; }
		[Ordinal(6)]  [RED("particleRadius")] public CFloat ParticleRadius { get; set; }
		[Ordinal(7)]  [RED("useGPUAcceleration")] public CBool UseGPUAcceleration { get; set; }
		[Ordinal(8)]  [RED("disableGravity")] public CBool DisableGravity { get; set; }
		[Ordinal(9)]  [RED("killOnCollision")] public CBool KillOnCollision { get; set; }

		public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
