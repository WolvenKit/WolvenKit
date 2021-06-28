using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnQuestNode : scnSceneGraphNode
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

		public scnQuestNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
