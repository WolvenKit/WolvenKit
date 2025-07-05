
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterPowerup_Record
	{
		[RED("libraryWidget")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryWidget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("scale")]
		[REDProperty(IsIgnored = true)]
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sfxPick")]
		[REDProperty(IsIgnored = true)]
		public CName SfxPick
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
