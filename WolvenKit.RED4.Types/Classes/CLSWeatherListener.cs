using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CLSWeatherListener : worldWeatherScriptListener
	{
		private CWeakHandle<CityLightSystem> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<CityLightSystem> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
