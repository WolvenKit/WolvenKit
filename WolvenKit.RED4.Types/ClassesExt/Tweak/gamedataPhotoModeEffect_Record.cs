
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeEffect_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("hdrLutPath")]
		[REDProperty(IsIgnored = true)]
		public CName HdrLutPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("locked")]
		[REDProperty(IsIgnored = true)]
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
