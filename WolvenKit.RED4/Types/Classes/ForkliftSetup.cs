using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForkliftSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionActivateName")] 
		public CName ActionActivateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("liftingAnimationTime")] 
		public CFloat LiftingAnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hasDistractionQuickhack")] 
		public CBool HasDistractionQuickhack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForkliftSetup()
		{
			ActionActivateName = "Activate";
			LiftingAnimationTime = 2.000000F;
			HasDistractionQuickhack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
