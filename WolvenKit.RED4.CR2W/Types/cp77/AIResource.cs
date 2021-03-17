using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIResource : LibTreeCTreeResource
	{
		private CHandle<AICTreeNodeDefinition> _root;

		[Ordinal(2)] 
		[RED("root")] 
		public CHandle<AICTreeNodeDefinition> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public AIResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
