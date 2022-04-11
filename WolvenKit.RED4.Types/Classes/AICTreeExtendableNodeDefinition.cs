using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeExtendableNodeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("optionalChild")] 
		public CHandle<LibTreeINodeDefinition> OptionalChild
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}
	}
}
