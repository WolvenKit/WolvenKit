using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeSlotData : animAnimFeature
	{
		[Ordinal(0)]  [RED("activeDuration")] public CFloat ActiveDuration { get; set; }
		[Ordinal(1)]  [RED("activeHitDuration")] public CFloat ActiveHitDuration { get; set; }
		[Ordinal(2)]  [RED("attackType")] public CInt32 AttackType { get; set; }
		[Ordinal(3)]  [RED("comboNumber")] public CInt32 ComboNumber { get; set; }
		[Ordinal(4)]  [RED("recoverDuration")] public CFloat RecoverDuration { get; set; }
		[Ordinal(5)]  [RED("recoverHitDuration")] public CFloat RecoverHitDuration { get; set; }
		[Ordinal(6)]  [RED("startupDuration")] public CFloat StartupDuration { get; set; }

		public animAnimFeature_MeleeSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
