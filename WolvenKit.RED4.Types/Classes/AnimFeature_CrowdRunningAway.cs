using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CrowdRunningAway : animAnimFeature
	{
		private CBool _isRunningAwayFromPlayersCar;

		[Ordinal(0)] 
		[RED("isRunningAwayFromPlayersCar")] 
		public CBool IsRunningAwayFromPlayersCar
		{
			get => GetProperty(ref _isRunningAwayFromPlayersCar);
			set => SetProperty(ref _isRunningAwayFromPlayersCar, value);
		}
	}
}
