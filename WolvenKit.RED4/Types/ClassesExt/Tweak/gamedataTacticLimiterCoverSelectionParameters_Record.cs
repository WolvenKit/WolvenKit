
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTacticLimiterCoverSelectionParameters_Record
	{
		[RED("addUtilityValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat AddUtilityValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
