using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
