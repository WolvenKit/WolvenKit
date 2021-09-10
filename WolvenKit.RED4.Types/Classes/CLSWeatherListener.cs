using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CLSWeatherListener : worldWeatherScriptListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<CityLightSystem> Owner
		{
			get => GetPropertyValue<CWeakHandle<CityLightSystem>>();
			set => SetPropertyValue<CWeakHandle<CityLightSystem>>(value);
		}
	}
}
