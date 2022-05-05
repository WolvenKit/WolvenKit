using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AINPCCommandStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetPropertyValue<CHandle<AICommand>>();
			set => SetPropertyValue<CHandle<AICommand>>(value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<AICommandState> NewState
		{
			get => GetPropertyValue<CEnum<AICommandState>>();
			set => SetPropertyValue<CEnum<AICommandState>>(value);
		}

		public AINPCCommandStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
