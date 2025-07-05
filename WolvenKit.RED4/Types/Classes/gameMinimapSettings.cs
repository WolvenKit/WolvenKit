using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMinimapSettings : IScriptable
	{
		[Ordinal(0)] 
		[RED("globalVisionRadiusBounds")] 
		public gameRange GlobalVisionRadiusBounds
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(1)] 
		[RED("visionRadiusVehicle")] 
		public gameRange VisionRadiusVehicle
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(2)] 
		[RED("visionRadiusCombat")] 
		public gameRange VisionRadiusCombat
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(3)] 
		[RED("visionRadiusQuestArea")] 
		public gameRange VisionRadiusQuestArea
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(4)] 
		[RED("visionRadiusSecurityArea")] 
		public gameRange VisionRadiusSecurityArea
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(5)] 
		[RED("visionRadiusInterior")] 
		public gameRange VisionRadiusInterior
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(6)] 
		[RED("visionRadiusExterior")] 
		public gameRange VisionRadiusExterior
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(7)] 
		[RED("speedBoundsSprint")] 
		public gameRange SpeedBoundsSprint
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(8)] 
		[RED("speedBoundsVehicle")] 
		public gameRange SpeedBoundsVehicle
		{
			get => GetPropertyValue<gameRange>();
			set => SetPropertyValue<gameRange>(value);
		}

		[Ordinal(9)] 
		[RED("smoothingStrengthOnZoomIn")] 
		public CFloat SmoothingStrengthOnZoomIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("smoothingStrengthOnZoomOut")] 
		public CFloat SmoothingStrengthOnZoomOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("playerMarkerTransitionSpeedOnVehicleMount")] 
		public CFloat PlayerMarkerTransitionSpeedOnVehicleMount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("playerMarkerTransitionSpeedOnVehicleUnmount")] 
		public CFloat PlayerMarkerTransitionSpeedOnVehicleUnmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("visionRadiusLocked")] 
		public CBool VisionRadiusLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("dynamicVisionRadiusEnabled")] 
		public CBool DynamicVisionRadiusEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("smoothingEnabled")] 
		public CBool SmoothingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMinimapSettings()
		{
			GlobalVisionRadiusBounds = new gameRange { MinValue = 1.000000F, MaxValue = 1000.000000F };
			VisionRadiusVehicle = new gameRange { MinValue = 200.000000F, MaxValue = 650.000000F };
			VisionRadiusCombat = new gameRange { MinValue = 40.000000F, MaxValue = 60.000000F };
			VisionRadiusQuestArea = new gameRange { MinValue = 40.000000F, MaxValue = 60.000000F };
			VisionRadiusSecurityArea = new gameRange { MinValue = 40.000000F, MaxValue = 60.000000F };
			VisionRadiusInterior = new gameRange { MinValue = 40.000000F, MaxValue = 60.000000F };
			VisionRadiusExterior = new gameRange { MinValue = 100.000000F, MaxValue = 110.000000F };
			SpeedBoundsSprint = new gameRange { MinValue = 4.000000F, MaxValue = 4.000000F };
			SpeedBoundsVehicle = new gameRange { MinValue = 15.000000F, MaxValue = 50.000000F };
			SmoothingStrengthOnZoomIn = 0.025000F;
			SmoothingStrengthOnZoomOut = 0.150000F;
			PlayerMarkerTransitionSpeedOnVehicleMount = 2.500000F;
			PlayerMarkerTransitionSpeedOnVehicleUnmount = 5.000000F;
			DynamicVisionRadiusEnabled = true;
			SmoothingEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
