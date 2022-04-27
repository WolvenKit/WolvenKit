using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveExplorationEnteredEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<moveExplorationType> Type
		{
			get => GetPropertyValue<CEnum<moveExplorationType>>();
			set => SetPropertyValue<CEnum<moveExplorationType>>(value);
		}

		public moveExplorationEnteredEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
