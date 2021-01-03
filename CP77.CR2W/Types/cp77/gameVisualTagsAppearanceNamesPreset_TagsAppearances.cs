using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
	{
		[Ordinal(0)]  [RED("appearanceNames")] public CArray<CName> AppearanceNames { get; set; }
		[Ordinal(1)]  [RED("visualTagHash")] public CName VisualTagHash { get; set; }

		public gameVisualTagsAppearanceNamesPreset_TagsAppearances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
