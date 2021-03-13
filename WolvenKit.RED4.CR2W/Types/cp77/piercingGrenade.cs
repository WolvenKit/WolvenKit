using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class piercingGrenade : BaseProjectile
	{
		[Ordinal(51)] [RED("piercingEffect")] public gameEffectRef PiercingEffect { get; set; }
		[Ordinal(52)] [RED("pierceTime")] public CFloat PierceTime { get; set; }
		[Ordinal(53)] [RED("energyLossFactor")] public CFloat EnergyLossFactor { get; set; }
		[Ordinal(54)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(55)] [RED("grenadeLifetime")] public CFloat GrenadeLifetime { get; set; }
		[Ordinal(56)] [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(57)] [RED("trailEffectName")] public CName TrailEffectName { get; set; }
		[Ordinal(58)] [RED("alive")] public CBool Alive { get; set; }

		public piercingGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
