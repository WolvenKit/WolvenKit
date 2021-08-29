using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _startVel;

		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetProperty(ref _startVel);
			set => SetProperty(ref _startVel, value);
		}
	}
}
