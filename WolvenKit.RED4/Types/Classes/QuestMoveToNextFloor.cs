using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMoveToNextFloor : ActionBool
	{
		[Ordinal(38)] 
		[RED("floor")] 
		public NodeRef Floor
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public QuestMoveToNextFloor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
