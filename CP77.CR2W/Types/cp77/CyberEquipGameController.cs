using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberEquipGameController : ArmorEquipGameController
	{
		[Ordinal(47)] [RED("eyesTags")] public CArray<CName> EyesTags { get; set; }
		[Ordinal(48)] [RED("brainTags")] public CArray<CName> BrainTags { get; set; }
		[Ordinal(49)] [RED("musculoskeletalTags")] public CArray<CName> MusculoskeletalTags { get; set; }
		[Ordinal(50)] [RED("nervousTags")] public CArray<CName> NervousTags { get; set; }
		[Ordinal(51)] [RED("cardiovascularTags")] public CArray<CName> CardiovascularTags { get; set; }
		[Ordinal(52)] [RED("immuneTags")] public CArray<CName> ImmuneTags { get; set; }
		[Ordinal(53)] [RED("integumentaryTags")] public CArray<CName> IntegumentaryTags { get; set; }
		[Ordinal(54)] [RED("handsTags")] public CArray<CName> HandsTags { get; set; }
		[Ordinal(55)] [RED("armsTags")] public CArray<CName> ArmsTags { get; set; }
		[Ordinal(56)] [RED("legsTags")] public CArray<CName> LegsTags { get; set; }
		[Ordinal(57)] [RED("quickSlotTags")] public CArray<CName> QuickSlotTags { get; set; }
		[Ordinal(58)] [RED("weaponsQuickSlotTags")] public CArray<CName> WeaponsQuickSlotTags { get; set; }
		[Ordinal(59)] [RED("fragmentTags")] public CArray<CName> FragmentTags { get; set; }

		public CyberEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
