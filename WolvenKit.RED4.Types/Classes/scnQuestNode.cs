using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
			IsockMappings = new();
			OsockMappings = new();
		}
	}
}
