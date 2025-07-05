
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAssignedVehicleInPanicDriving_Record
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
