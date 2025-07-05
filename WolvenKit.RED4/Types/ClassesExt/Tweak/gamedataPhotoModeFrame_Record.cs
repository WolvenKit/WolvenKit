
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeFrame_Record
	{
		[RED("atlasName")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AtlasName
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("color")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Color
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("flipHorizontal")]
		[REDProperty(IsIgnored = true)]
		public CBool FlipHorizontal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("flipVertical")]
		[REDProperty(IsIgnored = true)]
		public CBool FlipVertical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("imagePartsNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ImagePartsNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("libraryItemName")]
		[REDProperty(IsIgnored = true)]
		public CName LibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
