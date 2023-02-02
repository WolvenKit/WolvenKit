using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleUIInteractivity : redEvent
	{
		[Ordinal(0)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleUIInteractivity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
