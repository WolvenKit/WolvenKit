using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DischargeEvents : WeaponEventsTransition
	{
		[Ordinal(0)]  [RED("layerId")] public CUInt32 LayerId { get; set; }
		[Ordinal(1)]  [RED("statPoolsSystem")] public CHandle<gameStatPoolsSystem> StatPoolsSystem { get; set; }
		[Ordinal(2)]  [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(3)]  [RED("weaponID")] public entEntityID WeaponID { get; set; }

		public DischargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
