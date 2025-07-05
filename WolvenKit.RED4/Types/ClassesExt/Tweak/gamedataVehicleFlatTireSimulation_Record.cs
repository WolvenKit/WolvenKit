
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFlatTireSimulation_Record
	{
		[RED("front")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Front
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rear")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Rear
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
