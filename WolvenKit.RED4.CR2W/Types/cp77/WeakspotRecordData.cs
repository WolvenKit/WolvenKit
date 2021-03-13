using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotRecordData : CVariable
	{
		[Ordinal(0)] [RED("isInvulnerable")] public CBool IsInvulnerable { get; set; }
		[Ordinal(1)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(2)] [RED("reducedMeleeDamage")] public CBool ReducedMeleeDamage { get; set; }

		public WeakspotRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
