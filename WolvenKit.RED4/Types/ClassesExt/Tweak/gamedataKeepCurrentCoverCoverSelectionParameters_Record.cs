
namespace WolvenKit.RED4.Types
{
	public partial class gamedataKeepCurrentCoverCoverSelectionParameters_Record
	{
		[RED("keepCoverBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat KeepCoverBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
