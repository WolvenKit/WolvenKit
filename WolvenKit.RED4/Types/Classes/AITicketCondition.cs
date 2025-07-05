
namespace WolvenKit.RED4.Types
{
	public abstract partial class AITicketCondition : IScriptable
	{
		public AITicketCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
