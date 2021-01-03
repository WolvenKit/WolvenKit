using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		[Ordinal(0)]  [RED("angularVelocityDamp")] public CFloat AngularVelocityDamp { get; set; }
		[Ordinal(1)]  [RED("disableGravity")] public CBool DisableGravity { get; set; }
		[Ordinal(2)]  [RED("dynamicFriction")] public CFloat DynamicFriction { get; set; }
		[Ordinal(3)]  [RED("killOnCollision")] public CBool KillOnCollision { get; set; }
		[Ordinal(4)]  [RED("particleMass")] public CFloat ParticleMass { get; set; }
		[Ordinal(5)]  [RED("particleRadius")] public CFloat ParticleRadius { get; set; }
		[Ordinal(6)]  [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(7)]  [RED("staticFriction")] public CFloat StaticFriction { get; set; }
		[Ordinal(8)]  [RED("useGPUAcceleration")] public CBool UseGPUAcceleration { get; set; }
		[Ordinal(9)]  [RED("velocityDamp")] public CFloat VelocityDamp { get; set; }

		public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
