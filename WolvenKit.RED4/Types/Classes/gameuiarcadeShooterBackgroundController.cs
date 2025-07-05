using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterBackgroundController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("layerInfo")] 
		public CArray<gameuiarcadeShooterLayerInfo> LayerInfo
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterLayerInfo>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterLayerInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("allowMarginTranslation")] 
		public CBool AllowMarginTranslation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("expPlatformImageDetails")] 
		public CArray<gameuiarcadeShooterExplodingPlatformsImageWidgetDetail> ExpPlatformImageDetails
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterExplodingPlatformsImageWidgetDetail>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterExplodingPlatformsImageWidgetDetail>>(value);
		}

		public gameuiarcadeShooterBackgroundController()
		{
			LayerInfo = new();
			ExpPlatformImageDetails = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
