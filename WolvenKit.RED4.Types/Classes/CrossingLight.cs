using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLight : TrafficLight
	{
		private CBool _audioLightIsGreen;

		[Ordinal(90)] 
		[RED("audioLightIsGreen")] 
		public CBool AudioLightIsGreen
		{
			get => GetProperty(ref _audioLightIsGreen);
			set => SetProperty(ref _audioLightIsGreen, value);
		}
	}
}
