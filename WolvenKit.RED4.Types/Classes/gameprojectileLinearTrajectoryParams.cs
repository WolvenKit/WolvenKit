using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
