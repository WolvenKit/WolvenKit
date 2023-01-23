
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUphillDriveHelper_Record
	{
		[RED("slopeCompensationFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlopeCompensationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slopeCompensationMaxAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlopeCompensationMaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
