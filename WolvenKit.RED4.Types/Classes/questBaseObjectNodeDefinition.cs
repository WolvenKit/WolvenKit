using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questBaseObjectNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}
