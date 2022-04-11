using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeBrainDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>(value);
		}

		[Ordinal(1)] 
		[RED("useScoring")] 
		public CBool UseScoring
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeBrainDefinition()
		{
			Children = new();
		}
	}
}
