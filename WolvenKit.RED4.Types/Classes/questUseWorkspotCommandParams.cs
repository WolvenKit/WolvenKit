using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWorkspotCommandParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("moveToWorkspot")] 
		public CBool MoveToWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questUseWorkspotCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
