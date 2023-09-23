using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestExecuteTransition : redEvent
	{
		[Ordinal(0)] 
		[RED("transition")] 
		public AreaTypeTransition Transition
		{
			get => GetPropertyValue<AreaTypeTransition>();
			set => SetPropertyValue<AreaTypeTransition>(value);
		}

		public QuestExecuteTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
