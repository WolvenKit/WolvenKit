
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWidgetDefinition_Record
	{
		[RED("libraryID")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("libraryPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LibraryPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("ratios")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Ratios
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("styles")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Styles
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("useContentRatio")]
		[REDProperty(IsIgnored = true)]
		public CBool UseContentRatio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
