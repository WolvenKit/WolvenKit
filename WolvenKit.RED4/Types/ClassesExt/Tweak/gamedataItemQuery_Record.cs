
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemQuery_Record
	{
		[RED("excludeUnlocked")]
		[REDProperty(IsIgnored = true)]
		public CBool ExcludeUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("levelBasedQuality")]
		[REDProperty(IsIgnored = true)]
		public CBool LevelBasedQuality
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("qualityLevelModifier")]
		[REDProperty(IsIgnored = true)]
		public CInt32 QualityLevelModifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("tagsToExclude")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> TagsToExclude
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
