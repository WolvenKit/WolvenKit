using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeBrainDefinition : AICTreeNodeCompositeDefinition
	{
		private CArray<CHandle<LibTreeINodeDefinition>> _children;
		private CBool _useScoring;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(1)] 
		[RED("useScoring")] 
		public CBool UseScoring
		{
			get => GetProperty(ref _useScoring);
			set => SetProperty(ref _useScoring, value);
		}
	}
}
