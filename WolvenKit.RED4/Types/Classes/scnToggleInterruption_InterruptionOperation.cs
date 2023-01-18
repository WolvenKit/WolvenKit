using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnToggleInterruption_InterruptionOperation : scnIInterruptionOperation
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnToggleInterruption_InterruptionOperation()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
