
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAbsoluteZLimiterCoverSelectionParameters_Record
	{
		[RED("zLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
