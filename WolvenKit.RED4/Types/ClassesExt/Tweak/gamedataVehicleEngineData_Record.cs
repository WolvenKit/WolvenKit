
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleEngineData_Record
	{
		[RED("engineMaxTorque")]
		[REDProperty(IsIgnored = true)]
		public CFloat EngineMaxTorque
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fastR1GearChange")]
		[REDProperty(IsIgnored = true)]
		public CBool FastR1GearChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("finalGearTorqueDecimationScalor")]
		[REDProperty(IsIgnored = true)]
		public CFloat FinalGearTorqueDecimationScalor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("flyWheelMomentOfInertia")]
		[REDProperty(IsIgnored = true)]
		public CFloat FlyWheelMomentOfInertia
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("forceReverseRPMToMin")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceReverseRPMToMin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("gearChangeCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat GearChangeCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gearChangeTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat GearChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gearCurvesPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> GearCurvesPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("gears")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Gears
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("maxRPM")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRPM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minRPM")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinRPM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("resistanceTorque")]
		[REDProperty(IsIgnored = true)]
		public CFloat ResistanceTorque
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reverseDirDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat ReverseDirDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("wheelsResistanceRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat WheelsResistanceRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
