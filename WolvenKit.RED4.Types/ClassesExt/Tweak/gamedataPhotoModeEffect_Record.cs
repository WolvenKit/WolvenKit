
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeEffect_Record
	{
		[RED("hdrLutPath")]
		[REDProperty(IsIgnored = true)]
		public CName HdrLutPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("lutPath")]
		[REDProperty(IsIgnored = true)]
		public CName LutPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
