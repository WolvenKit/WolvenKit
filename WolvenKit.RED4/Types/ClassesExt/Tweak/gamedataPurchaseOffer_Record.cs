
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPurchaseOffer_Record
	{
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("previewImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PreviewImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("price")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Price
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
