
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelDrivingSetup_2_Record
	{
		[RED("B")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID B
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("F")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID F
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
