using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleGranade : BaseProjectile
	{
		[Ordinal(51)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(52)] [RED("energyLossFactor")] public CFloat EnergyLossFactor { get; set; }
		[Ordinal(53)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(54)] [RED("grenadeLifetime")] public CFloat GrenadeLifetime { get; set; }
		[Ordinal(55)] [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(56)] [RED("trailEffectName")] public CName TrailEffectName { get; set; }
		[Ordinal(57)] [RED("alive")] public CBool Alive { get; set; }

		public sampleGranade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
