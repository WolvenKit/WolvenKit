using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBehaviourSpot : AISmartSpot
	{
		[Ordinal(0)] 
		[RED("behaviour")] 
		public CHandle<AIResourceReference> Behaviour
		{
			get => GetPropertyValue<CHandle<AIResourceReference>>();
			set => SetPropertyValue<CHandle<AIResourceReference>>(value);
		}
	}
}
