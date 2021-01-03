using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberEquipGameController : ArmorEquipGameController
	{
		[Ordinal(0)]  [RED("armsTags")] public CArray<CName> ArmsTags { get; set; }
		[Ordinal(1)]  [RED("brainTags")] public CArray<CName> BrainTags { get; set; }
		[Ordinal(2)]  [RED("cardiovascularTags")] public CArray<CName> CardiovascularTags { get; set; }
		[Ordinal(3)]  [RED("eyesTags")] public CArray<CName> EyesTags { get; set; }
		[Ordinal(4)]  [RED("fragmentTags")] public CArray<CName> FragmentTags { get; set; }
		[Ordinal(5)]  [RED("handsTags")] public CArray<CName> HandsTags { get; set; }
		[Ordinal(6)]  [RED("immuneTags")] public CArray<CName> ImmuneTags { get; set; }
		[Ordinal(7)]  [RED("integumentaryTags")] public CArray<CName> IntegumentaryTags { get; set; }
		[Ordinal(8)]  [RED("legsTags")] public CArray<CName> LegsTags { get; set; }
		[Ordinal(9)]  [RED("musculoskeletalTags")] public CArray<CName> MusculoskeletalTags { get; set; }
		[Ordinal(10)]  [RED("nervousTags")] public CArray<CName> NervousTags { get; set; }
		[Ordinal(11)]  [RED("quickSlotTags")] public CArray<CName> QuickSlotTags { get; set; }
		[Ordinal(12)]  [RED("weaponsQuickSlotTags")] public CArray<CName> WeaponsQuickSlotTags { get; set; }

		public CyberEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
