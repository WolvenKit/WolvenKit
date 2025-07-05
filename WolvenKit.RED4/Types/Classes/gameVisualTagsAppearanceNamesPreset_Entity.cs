using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisualTagsAppearanceNamesPreset_Entity : ISerializable
	{
		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("tagsToAppearances")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> TagsToAppearances
		{
			get => GetPropertyValue<CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances>>();
			set => SetPropertyValue<CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances>>(value);
		}

		public gameVisualTagsAppearanceNamesPreset_Entity()
		{
			TagsToAppearances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
