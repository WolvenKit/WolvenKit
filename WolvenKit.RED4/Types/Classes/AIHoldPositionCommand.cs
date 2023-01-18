using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHoldPositionCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIHoldPositionCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
