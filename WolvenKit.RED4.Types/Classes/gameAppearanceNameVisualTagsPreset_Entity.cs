using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAppearanceNameVisualTagsPreset_Entity : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CName _debugEntityPath;
		private CUInt64 _entityRigPathHash;
		private CName _debugEntityRigPath;
		private redTagList _commonVisualTags;
		private CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> _appearancesToTags;

		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetProperty(ref _entityPathHash);
			set => SetProperty(ref _entityPathHash, value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get => GetProperty(ref _debugEntityPath);
			set => SetProperty(ref _debugEntityPath, value);
		}

		[Ordinal(2)] 
		[RED("entityRigPathHash")] 
		public CUInt64 EntityRigPathHash
		{
			get => GetProperty(ref _entityRigPathHash);
			set => SetProperty(ref _entityRigPathHash, value);
		}

		[Ordinal(3)] 
		[RED("debugEntityRigPath")] 
		public CName DebugEntityRigPath
		{
			get => GetProperty(ref _debugEntityRigPath);
			set => SetProperty(ref _debugEntityRigPath, value);
		}

		[Ordinal(4)] 
		[RED("commonVisualTags")] 
		public redTagList CommonVisualTags
		{
			get => GetProperty(ref _commonVisualTags);
			set => SetProperty(ref _commonVisualTags, value);
		}

		[Ordinal(5)] 
		[RED("appearancesToTags")] 
		public CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> AppearancesToTags
		{
			get => GetProperty(ref _appearancesToTags);
			set => SetProperty(ref _appearancesToTags, value);
		}
	}
}
