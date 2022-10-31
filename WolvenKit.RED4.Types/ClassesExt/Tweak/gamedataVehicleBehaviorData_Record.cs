
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleBehaviorData_Record
	{
		[RED("readyToParkDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ReadyToParkDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
