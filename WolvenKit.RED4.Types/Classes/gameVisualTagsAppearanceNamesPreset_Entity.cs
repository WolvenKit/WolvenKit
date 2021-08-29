using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisualTagsAppearanceNamesPreset_Entity : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CName _debugEntityPath;
		private CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> _tagsToAppearances;

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
		[RED("tagsToAppearances")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> TagsToAppearances
		{
			get => GetProperty(ref _tagsToAppearances);
			set => SetProperty(ref _tagsToAppearances, value);
		}
	}
}
