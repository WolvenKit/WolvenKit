using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitHistoryItem : CVariable
	{
		[Ordinal(0)]  [RED("hitTime")] public CFloat HitTime { get; set; }
		[Ordinal(1)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(2)]  [RED("isMelee")] public CBool IsMelee { get; set; }

		public HitHistoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
