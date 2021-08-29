using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questBaseObjectNodeDefinition : questDisableableNodeDefinition
	{
		private NodeRef _reference;

		[Ordinal(2)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}
	}
}
