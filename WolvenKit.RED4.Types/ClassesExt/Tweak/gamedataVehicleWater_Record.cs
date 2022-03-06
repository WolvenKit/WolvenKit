
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWater_Record
	{
		[RED("angularDampingCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngularDampingCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("buoyancyCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat BuoyancyCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("depthThresholdForFallFx")]
		[REDProperty(IsIgnored = true)]
		public CFloat DepthThresholdForFallFx
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("disableAirControl")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableAirControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("disableEngine")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableEngine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("impulseOverhangDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseOverhangDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("impulseRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("impulseStrength")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("impulseStrengthFallMultiplierMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseStrengthFallMultiplierMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("impulseStrengthFallMultiplierMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseStrengthFallMultiplierMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("linearDampingCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat LinearDampingCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxVehicleSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxVehicleSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistanceBetweenFx")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistanceBetweenFx
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistanceBetweenImpulses")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistanceBetweenImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minSpeedToApplyImpulses")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinSpeedToApplyImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paramVehicleSpeed")]
		[REDProperty(IsIgnored = true)]
		public CName ParamVehicleSpeed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("submergedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat SubmergedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("verticalVelocityThresholdForFallFx")]
		[REDProperty(IsIgnored = true)]
		public CFloat VerticalVelocityThresholdForFallFx
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("vfx_impact_water")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_impact_water
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
