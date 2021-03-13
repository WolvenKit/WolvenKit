using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitHistoryItem : CVariable
	{
		[Ordinal(0)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(1)] [RED("hitTime")] public CFloat HitTime { get; set; }
		[Ordinal(2)] [RED("isMelee")] public CBool IsMelee { get; set; }

		public HitHistoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
