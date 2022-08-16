
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChoiceCaptionIconPart_Record
	{
		[RED("comment")]
		[REDProperty(IsIgnored = true)]
		public CString Comment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mappinVariant")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MappinVariant
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("texturePartID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TexturePartID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
