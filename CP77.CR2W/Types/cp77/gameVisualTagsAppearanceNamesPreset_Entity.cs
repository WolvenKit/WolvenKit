using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_Entity : ISerializable
	{
		[Ordinal(0)]  [RED("debugEntityPath")] public CName DebugEntityPath { get; set; }
		[Ordinal(1)]  [RED("entityPathHash")] public CUInt64 EntityPathHash { get; set; }
		[Ordinal(2)]  [RED("tagsToAppearances")] public CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> TagsToAppearances { get; set; }

		public gameVisualTagsAppearanceNamesPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
