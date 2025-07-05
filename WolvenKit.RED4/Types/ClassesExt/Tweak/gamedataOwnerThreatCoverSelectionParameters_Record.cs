
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOwnerThreatCoverSelectionParameters_Record
	{
		[RED("ownerThreatCoverAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat OwnerThreatCoverAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
