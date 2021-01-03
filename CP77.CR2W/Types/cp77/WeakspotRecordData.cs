using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeakspotRecordData : CVariable
	{
		[Ordinal(0)]  [RED("isInvulnerable")] public CBool IsInvulnerable { get; set; }
		[Ordinal(1)]  [RED("reducedMeleeDamage")] public CBool ReducedMeleeDamage { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public WeakspotRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
