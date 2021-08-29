using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIResource : LibTreeCTreeResource
	{
		private CHandle<AICTreeNodeDefinition> _root;

		[Ordinal(2)] 
		[RED("root")] 
		public CHandle<AICTreeNodeDefinition> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
