using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIncludedTreeDefinition : AIbehaviorNestedTreeDefinition
	{
		private CHandle<AIArgumentMapping> _treeReference;

		[Ordinal(2)] 
		[RED("treeReference")] 
		public CHandle<AIArgumentMapping> TreeReference
		{
			get => GetProperty(ref _treeReference);
			set => SetProperty(ref _treeReference, value);
		}
	}
}
