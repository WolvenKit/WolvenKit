using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class nanowireGrenade : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(2)]  [RED("energyLossFactor")] public CFloat EnergyLossFactor { get; set; }
		[Ordinal(3)]  [RED("explosionEffect")] public CHandle<gameEffectInstance> ExplosionEffect { get; set; }
		[Ordinal(4)]  [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(5)]  [RED("grenadeLifetime")] public CFloat GrenadeLifetime { get; set; }
		[Ordinal(6)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(7)]  [RED("timeToActivation")] public CFloat TimeToActivation { get; set; }
		[Ordinal(8)]  [RED("trailEffectName")] public CName TrailEffectName { get; set; }

		public nanowireGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
