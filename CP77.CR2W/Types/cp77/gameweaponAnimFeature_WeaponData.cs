using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_WeaponData : animAnimFeature
	{
		[Ordinal(0)]  [RED("cycleTime")] public CFloat CycleTime { get; set; }
		[Ordinal(1)]  [RED("chargePercentage")] public CFloat ChargePercentage { get; set; }
		[Ordinal(2)]  [RED("timeInMaxCharge")] public CFloat TimeInMaxCharge { get; set; }
		[Ordinal(3)]  [RED("ammoRemaining")] public CInt32 AmmoRemaining { get; set; }
		[Ordinal(4)]  [RED("triggerMode")] public CInt32 TriggerMode { get; set; }
		[Ordinal(5)]  [RED("isMagazineFull")] public CBool IsMagazineFull { get; set; }
		[Ordinal(6)]  [RED("isTriggerDown")] public CBool IsTriggerDown { get; set; }

		public gameweaponAnimFeature_WeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
