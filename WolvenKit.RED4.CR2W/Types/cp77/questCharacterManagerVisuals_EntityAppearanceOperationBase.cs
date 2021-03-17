using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_EntityAppearanceOperationBase : questICharacterManagerVisuals_NodeSubType
	{
		private CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> _appearanceEntries;

		[Ordinal(0)] 
		[RED("appearanceEntries")] 
		public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries
		{
			get => GetProperty(ref _appearanceEntries);
			set => SetProperty(ref _appearanceEntries, value);
		}

		public questCharacterManagerVisuals_EntityAppearanceOperationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
