using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceExitDelamainEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldExit")] 
		public CBool ShouldExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForceExitDelamainEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
