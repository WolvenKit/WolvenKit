using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryItemAbility : CVariable
	{
		[Ordinal(0)] [RED("IconPath")] public CName IconPath { get; set; }
		[Ordinal(1)] [RED("Title")] public CString Title { get; set; }
		[Ordinal(2)] [RED("Description")] public CString Description { get; set; }
		[Ordinal(3)] [RED("LocalizationDataPackage")] public CHandle<gameUILocalizationDataPackage> LocalizationDataPackage { get; set; }

		public gameInventoryItemAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
