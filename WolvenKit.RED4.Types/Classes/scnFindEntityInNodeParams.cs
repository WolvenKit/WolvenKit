using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnFindEntityInNodeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
