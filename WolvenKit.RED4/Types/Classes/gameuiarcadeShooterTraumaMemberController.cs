using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterTraumaMemberController : gameuiarcadeShooterObjectController
	{
		[Ordinal(3)] 
		[RED("baseFollowDelay")] 
		public CFloat BaseFollowDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiarcadeShooterTraumaMemberController()
		{
			BaseFollowDelay = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
