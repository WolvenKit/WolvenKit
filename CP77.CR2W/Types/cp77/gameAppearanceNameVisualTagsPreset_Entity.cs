using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAppearanceNameVisualTagsPreset_Entity : ISerializable
	{
		[Ordinal(0)]  [RED("commonVisualTags")] public redTagList CommonVisualTags { get; set; }
		[Ordinal(1)]  [RED("appearancesToTags")] public CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> AppearancesToTags { get; set; }
		[Ordinal(2)]  [RED("entityPathHash")] public CUInt64 EntityPathHash { get; set; }
		[Ordinal(3)]  [RED("debugEntityPath")] public CName DebugEntityPath { get; set; }
		[Ordinal(4)]  [RED("entityRigPathHash")] public CUInt64 EntityRigPathHash { get; set; }
		[Ordinal(5)]  [RED("debugEntityRigPath")] public CName DebugEntityRigPath { get; set; }

		public gameAppearanceNameVisualTagsPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
