using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChaosWeaponCustomEffector : gameEffector
	{
		[Ordinal(0)]  [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(1)]  [RED("effectorOwner")] public wCHandle<gameObject> EffectorOwner { get; set; }
		[Ordinal(2)]  [RED("modGroupID")] public CUInt64 ModGroupID { get; set; }
		[Ordinal(3)]  [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(4)]  [RED("target")] public gameStatsObjectID Target { get; set; }

		public ChaosWeaponCustomEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
