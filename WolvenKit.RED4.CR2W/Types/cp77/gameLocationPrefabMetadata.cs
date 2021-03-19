using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLocationPrefabMetadata : worldPrefabMetadata
	{
		private CArray<CName> _tags;
		private CBool _ignoreParentPrefabs;

		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get => GetProperty(ref _ignoreParentPrefabs);
			set => SetProperty(ref _ignoreParentPrefabs, value);
		}

		public gameLocationPrefabMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
