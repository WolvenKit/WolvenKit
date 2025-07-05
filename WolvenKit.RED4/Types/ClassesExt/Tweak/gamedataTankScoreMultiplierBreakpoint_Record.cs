
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankScoreMultiplierBreakpoint_Record
	{
		[RED("percentage")]
		[REDProperty(IsIgnored = true)]
		public CFloat Percentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
