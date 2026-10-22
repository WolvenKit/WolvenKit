using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExecuteVisualCustomizationWithDelay : redEvent
	{
		[Ordinal(0)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExecuteVisualCustomizationWithDelay()
		{
			Template = new VehicleVisualCustomizationTemplate();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
