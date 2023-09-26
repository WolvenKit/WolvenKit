
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAssignedVehicleInRace_Record
	{
		[RED("vehicle")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vehicle
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
