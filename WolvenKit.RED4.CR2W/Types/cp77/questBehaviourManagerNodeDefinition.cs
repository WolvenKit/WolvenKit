using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
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

		public questBehaviourManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
