using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatGroupEffector : gameEffector
	{
		[Ordinal(0)] [RED("effectorOwner")] public wCHandle<gameObject> EffectorOwner { get; set; }
		[Ordinal(1)] [RED("target")] public gameStatsObjectID Target { get; set; }
		[Ordinal(2)] [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(3)] [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(4)] [RED("modGroupID")] public CUInt64 ModGroupID { get; set; }

		public ApplyStatGroupEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
