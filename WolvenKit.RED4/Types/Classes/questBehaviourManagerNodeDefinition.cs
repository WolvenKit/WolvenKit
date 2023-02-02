using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CHandle<workIWorkspotQuestAction> Type
		{
			get => GetPropertyValue<CHandle<workIWorkspotQuestAction>>();
			set => SetPropertyValue<CHandle<workIWorkspotQuestAction>>(value);
		}

		[Ordinal(4)] 
		[RED("newType")] 
		public CHandle<questIBehaviourManager_NodeType> NewType
		{
			get => GetPropertyValue<CHandle<questIBehaviourManager_NodeType>>();
			set => SetPropertyValue<CHandle<questIBehaviourManager_NodeType>>(value);
		}

		public questBehaviourManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Puppet = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
