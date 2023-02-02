using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEnableScanningStatePropagationToParentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEnableScanningStatePropagationToParentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
