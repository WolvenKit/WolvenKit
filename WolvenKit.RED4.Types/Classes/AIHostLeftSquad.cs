using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIHostLeftSquad : AIAIEvent
	{
		private CWeakHandle<AISquadScriptInterface> _squadInterface;

		[Ordinal(2)] 
		[RED("squadInterface")] 
		public CWeakHandle<AISquadScriptInterface> SquadInterface
		{
			get => GetProperty(ref _squadInterface);
			set => SetProperty(ref _squadInterface, value);
		}
	}
}
