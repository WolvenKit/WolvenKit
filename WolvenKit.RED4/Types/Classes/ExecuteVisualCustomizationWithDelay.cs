using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExecuteVisualCustomizationWithDelay : redEvent
	{
		[Ordinal(0)] 
		[RED("modSet")] 
		public vehicleVisualModdingDefinition ModSet
		{
			get => GetPropertyValue<vehicleVisualModdingDefinition>();
			set => SetPropertyValue<vehicleVisualModdingDefinition>(value);
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
			ModSet = new vehicleVisualModdingDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
