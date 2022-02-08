using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_ItemRebalancer : gameObject
	{
		[Ordinal(40)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}
