using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTriggerNotifier_Entity : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("entityRef")] 
		public NodeRef EntityRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public entTriggerNotifier_Entity()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
