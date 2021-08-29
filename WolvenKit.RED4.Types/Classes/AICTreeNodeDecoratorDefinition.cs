using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDecoratorDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _child;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}
	}
}
