using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset : ISerializable
	{
		[Ordinal(0)] [RED("presets")] public CArray<gameVisualTagsAppearanceNamesPreset_Entity> Presets { get; set; }

		public gameVisualTagsAppearanceNamesPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
