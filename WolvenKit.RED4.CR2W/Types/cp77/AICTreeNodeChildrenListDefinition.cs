using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeChildrenListDefinition : AICTreeNodeCompositeDefinition
	{
		private CArray<CHandle<LibTreeINodeDefinition>> _children;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		public AICTreeNodeChildrenListDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
