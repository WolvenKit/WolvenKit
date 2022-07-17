
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelScreenDataGroup_Record
	{
		[RED("screensData")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ScreensData
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
