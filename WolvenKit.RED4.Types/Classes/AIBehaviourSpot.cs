using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBehaviourSpot : AISmartSpot
	{
		private CHandle<AIResourceReference> _behaviour;

		[Ordinal(0)] 
		[RED("behaviour")] 
		public CHandle<AIResourceReference> Behaviour
		{
			get => GetProperty(ref _behaviour);
			set => SetProperty(ref _behaviour, value);
		}
	}
}
