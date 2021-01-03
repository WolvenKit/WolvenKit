using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_EntityAppearanceOperationBase : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)]  [RED("appearanceEntries")] public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries { get; set; }

		public questCharacterManagerVisuals_EntityAppearanceOperationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
