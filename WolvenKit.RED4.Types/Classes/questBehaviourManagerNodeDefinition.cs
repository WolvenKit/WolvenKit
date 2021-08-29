using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _puppet;
		private CHandle<workIWorkspotQuestAction> _type;
		private CHandle<questIBehaviourManager_NodeType> _newType;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CHandle<workIWorkspotQuestAction> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("newType")] 
		public CHandle<questIBehaviourManager_NodeType> NewType
		{
			get => GetProperty(ref _newType);
			set => SetProperty(ref _newType, value);
		}
	}
}
