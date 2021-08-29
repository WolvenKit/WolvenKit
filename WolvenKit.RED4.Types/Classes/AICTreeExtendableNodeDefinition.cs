using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeExtendableNodeDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _optionalChild;

		[Ordinal(0)] 
		[RED("optionalChild")] 
		public CHandle<LibTreeINodeDefinition> OptionalChild
		{
			get => GetProperty(ref _optionalChild);
			set => SetProperty(ref _optionalChild, value);
		}
	}
}
