
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeMenu_Record
	{
		[RED("arcadeMenuOptionClickedSFX")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeMenuOptionClickedSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeMenuOptionSelectedSFX")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeMenuOptionSelectedSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
