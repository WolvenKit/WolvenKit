
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSpawnableObject_Record
	{
		[RED("appearanceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("entityTemplatePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> EntityTemplatePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("multiplayerTemplatePaths")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> MultiplayerTemplatePaths
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("persistentName")]
		[REDProperty(IsIgnored = true)]
		public CName PersistentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Priority
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("visualTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
