using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnQuestNode : scnSceneGraphNode
	{
		private CHandle<questNodeDefinition> _questNode;
		private CArray<CName> _isockMappings;
		private CArray<CName> _osockMappings;

		[Ordinal(3)] 
		[RED("questNode")] 
		public CHandle<questNodeDefinition> QuestNode
		{
			get => GetProperty(ref _questNode);
			set => SetProperty(ref _questNode, value);
		}

		[Ordinal(4)] 
		[RED("isockMappings")] 
		public CArray<CName> IsockMappings
		{
			get => GetProperty(ref _isockMappings);
			set => SetProperty(ref _isockMappings, value);
		}

		[Ordinal(5)] 
		[RED("osockMappings")] 
		public CArray<CName> OsockMappings
		{
			get => GetProperty(ref _osockMappings);
			set => SetProperty(ref _osockMappings, value);
		}
	}
}
