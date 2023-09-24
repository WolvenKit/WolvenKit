
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankBackgroundData_Record
	{
		[RED("backgroundLayerList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BackgroundLayerList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("decorationSpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName DecorationSpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
