using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHostLeftSquad : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("squadInterface")] 
		public CWeakHandle<AISquadScriptInterface> SquadInterface
		{
			get => GetPropertyValue<CWeakHandle<AISquadScriptInterface>>();
			set => SetPropertyValue<CWeakHandle<AISquadScriptInterface>>(value);
		}

		public AIHostLeftSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
