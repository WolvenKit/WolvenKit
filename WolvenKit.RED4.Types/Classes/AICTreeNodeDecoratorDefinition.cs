using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDecoratorDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}
	}
}
