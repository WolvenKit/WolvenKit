using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAppearanceNameVisualTagsPreset_Entity : ISerializable
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
		[RED("entityRigPathHash")] 
		public CUInt64 EntityRigPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("debugEntityRigPath")] 
		public CName DebugEntityRigPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("commonVisualTags")] 
		public redTagList CommonVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(5)] 
		[RED("appearancesToTags")] 
		public CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> AppearancesToTags
		{
			get => GetPropertyValue<CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags>>();
			set => SetPropertyValue<CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags>>(value);
		}

		public gameAppearanceNameVisualTagsPreset_Entity()
		{
			CommonVisualTags = new() { Tags = new() };
			AppearancesToTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
