
namespace WolvenKit.RED4.Types
{
	public partial class gamedataScreenMessageData_Record
	{
		[RED("autoScroll")]
		[REDProperty(IsIgnored = true)]
		public CBool AutoScroll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("backgroundColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> BackgroundColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("backgroundOpacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat BackgroundOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("backgroundTextureID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackgroundTextureID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("bottomMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat BottomMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fontPath")]
		[REDProperty(IsIgnored = true)]
		public CString FontPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("fontSize")]
		[REDProperty(IsIgnored = true)]
		public CInt32 FontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("fontStyle")]
		[REDProperty(IsIgnored = true)]
		public CName FontStyle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("friendlyName")]
		[REDProperty(IsIgnored = true)]
		public CString FriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("leftMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat LeftMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("messageGroup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MessageGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rightMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat RightMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("scrollSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat ScrollSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("textColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> TextColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("textHorizontalAlignment")]
		[REDProperty(IsIgnored = true)]
		public CName TextHorizontalAlignment
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("textVerticalAlignment")]
		[REDProperty(IsIgnored = true)]
		public CName TextVerticalAlignment
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("topMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat TopMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
