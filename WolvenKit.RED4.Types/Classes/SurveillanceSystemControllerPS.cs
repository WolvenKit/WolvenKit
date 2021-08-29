using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
	{
		private CBool _isRevealingEnemies;

		[Ordinal(106)] 
		[RED("isRevealingEnemies")] 
		public CBool IsRevealingEnemies
		{
			get => GetProperty(ref _isRevealingEnemies);
			set => SetProperty(ref _isRevealingEnemies, value);
		}
	}
}
