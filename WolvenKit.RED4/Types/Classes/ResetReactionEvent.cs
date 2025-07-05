using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetReactionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<AIReactionData> Data
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		public ResetReactionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
