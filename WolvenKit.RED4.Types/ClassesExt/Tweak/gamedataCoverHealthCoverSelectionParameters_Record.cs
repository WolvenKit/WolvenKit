
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCoverHealthCoverSelectionParameters_Record
	{
		[RED("hpMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat HpMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
