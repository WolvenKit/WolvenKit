using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class nanowireGrenade : BaseProjectile
	{
		[Ordinal(51)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(52)] [RED("timeToActivation")] public CFloat TimeToActivation { get; set; }
		[Ordinal(53)] [RED("energyLossFactor")] public CFloat EnergyLossFactor { get; set; }
		[Ordinal(54)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(55)] [RED("grenadeLifetime")] public CFloat GrenadeLifetime { get; set; }
		[Ordinal(56)] [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(57)] [RED("trailEffectName")] public CName TrailEffectName { get; set; }
		[Ordinal(58)] [RED("alive")] public CBool Alive { get; set; }

		public nanowireGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
