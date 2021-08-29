using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LightDirectionSettings : IAreaSettings
	{
		private GlobalLightingTrajectoryOverride _direction;

		[Ordinal(2)] 
		[RED("direction")] 
		public GlobalLightingTrajectoryOverride Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
