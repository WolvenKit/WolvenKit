using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnQuestNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("questNode")] 
		public CHandle<questNodeDefinition> QuestNode
		{
			get => GetPropertyValue<CHandle<questNodeDefinition>>();
			set => SetPropertyValue<CHandle<questNodeDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("isockMappings")] 
		public CArray<CName> IsockMappings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("osockMappings")] 
		public CArray<CName> OsockMappings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public scnQuestNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();
			IsockMappings = new();
			OsockMappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
