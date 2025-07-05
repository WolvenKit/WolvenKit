
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNonLinearAccuracy_Record
	{
		[RED("exponent")]
		[REDProperty(IsIgnored = true)]
		public CFloat Exponent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("timeFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimeFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
