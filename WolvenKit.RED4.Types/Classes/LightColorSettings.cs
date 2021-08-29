using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LightColorSettings : IAreaSettings
	{
		private worldWorldGlobalLightParameters _light;

		[Ordinal(2)] 
		[RED("light")] 
		public worldWorldGlobalLightParameters Light
		{
			get => GetProperty(ref _light);
			set => SetProperty(ref _light, value);
		}
	}
}
