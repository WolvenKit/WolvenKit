using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameLocationPrefabMetadata : worldPrefabMetadata
	{
		[Ordinal(0)]  [RED("ignoreParentPrefabs")] public CBool IgnoreParentPrefabs { get; set; }
		[Ordinal(1)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public gameLocationPrefabMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
