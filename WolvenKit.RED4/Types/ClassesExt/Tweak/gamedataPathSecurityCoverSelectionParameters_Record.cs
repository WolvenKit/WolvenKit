
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPathSecurityCoverSelectionParameters_Record
	{
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pathSampleDist")]
		[REDProperty(IsIgnored = true)]
		public CFloat PathSampleDist
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("threatHalfSightAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatHalfSightAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("threatSightRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatSightRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
