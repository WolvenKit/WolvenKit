using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ncartMetroObject : vehicleAVBaseObject
	{
		[Ordinal(64)] 
		[RED("pitchAdjustmentDelayID")] 
		public gameDelayID PitchAdjustmentDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(65)] 
		[RED("Z")] 
		public CFloat Z
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("checkForLeveling")] 
		public CBool CheckForLeveling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("pitchingValue")] 
		public CInt32 PitchingValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(68)] 
		[RED("pitchAngleCheckInterval")] 
		public CFloat PitchAngleCheckInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("pitchAngleReturnInterval")] 
		public CFloat PitchAngleReturnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("trainReverseDirectionFactName")] 
		public CName TrainReverseDirectionFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(71)] 
		[RED("pitchAngleAdjustmentTreshold")] 
		public CFloat PitchAngleAdjustmentTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(72)] 
		[RED("pitchAngleLevelOutTreshold")] 
		public CFloat PitchAngleLevelOutTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ncartMetroObject()
		{
			PitchAdjustmentDelayID = new gameDelayID();
			PitchAngleCheckInterval = 0.400000F;
			PitchAngleReturnInterval = 0.750000F;
			TrainReverseDirectionFactName = "ue_metro_track_reverse";
			PitchAngleAdjustmentTreshold = 0.900000F;
			PitchAngleLevelOutTreshold = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
