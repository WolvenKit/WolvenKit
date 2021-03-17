using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		private gameEntityReference _entityReference;
		private CName _moveType;
		private CHandle<questAICommandParams> _nodeParams;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("moveType")] 
		public CName MoveType
		{
			get => GetProperty(ref _moveType);
			set => SetProperty(ref _moveType, value);
		}

		[Ordinal(4)] 
		[RED("nodeParams")] 
		public CHandle<questAICommandParams> NodeParams
		{
			get => GetProperty(ref _nodeParams);
			set => SetProperty(ref _nodeParams, value);
		}

		public questMovePuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
