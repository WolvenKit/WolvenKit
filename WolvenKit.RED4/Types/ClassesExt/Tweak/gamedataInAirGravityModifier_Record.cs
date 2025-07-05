
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInAirGravityModifier_Record
	{
		[RED("baseAddedGravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat BaseAddedGravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driveSpeedAddedGravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriveSpeedAddedGravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxDriveSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDriveSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDriveSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDriveSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("smoothingFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SmoothingFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("zVelReductionEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZVelReductionEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("zVelReductionStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZVelReductionStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
