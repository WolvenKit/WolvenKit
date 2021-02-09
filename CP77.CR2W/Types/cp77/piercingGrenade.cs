using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class piercingGrenade : BaseProjectile
	{
		[Ordinal(41)]  [RED("piercingEffect")] public gameEffectRef PiercingEffect { get; set; }
		[Ordinal(42)]  [RED("pierceTime")] public CFloat PierceTime { get; set; }
		[Ordinal(43)]  [RED("energyLossFactor")] public CFloat EnergyLossFactor { get; set; }
		[Ordinal(44)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(45)]  [RED("grenadeLifetime")] public CFloat GrenadeLifetime { get; set; }
		[Ordinal(46)]  [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(47)]  [RED("trailEffectName")] public CName TrailEffectName { get; set; }
		[Ordinal(48)]  [RED("alive")] public CBool Alive { get; set; }

		public piercingGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
