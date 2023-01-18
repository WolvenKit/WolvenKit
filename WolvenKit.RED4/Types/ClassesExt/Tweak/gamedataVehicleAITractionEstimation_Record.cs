
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAITractionEstimation_Record
	{
		[RED("brakingAccelFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrakingAccelFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("forwardAccelFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat ForwardAccelFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turningAccelFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurningAccelFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
