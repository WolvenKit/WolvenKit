using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveLinkedStatusEffectsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RemoveLinkedStatusEffectsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
