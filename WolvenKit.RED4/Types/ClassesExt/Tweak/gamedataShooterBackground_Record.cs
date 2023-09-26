
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterBackground_Record
	{
		[RED("layerList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LayerList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startSFX")]
		[REDProperty(IsIgnored = true)]
		public CName StartSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("stopSFX")]
		[REDProperty(IsIgnored = true)]
		public CName StopSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
