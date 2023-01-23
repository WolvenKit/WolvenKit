using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHumanoidBody : entIComponent
	{
		[Ordinal(3)] 
		[RED("basePersonalSpace")] 
		public CFloat BasePersonalSpace
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("baseHeight")] 
		public CFloat BaseHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("baseEyesHeightRatio")] 
		public CFloat BaseEyesHeightRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("aimAnimFeatureName")] 
		public CName AimAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameHumanoidBody()
		{
			Name = "Component";
			BasePersonalSpace = 0.350000F;
			BaseHeight = 1.800000F;
			BaseEyesHeightRatio = 0.950000F;
			StanceAnimFeatureName = "stanceStyle";
			AimAnimFeatureName = "aim";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
