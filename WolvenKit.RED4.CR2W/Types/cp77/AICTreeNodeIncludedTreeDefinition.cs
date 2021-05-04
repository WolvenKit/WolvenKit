using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeIncludedTreeDefinition : AICTreeNodeDefinition
	{
		private LibTreeDefTree _tree;

		[Ordinal(0)] 
		[RED("tree")] 
		public LibTreeDefTree Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}

		public AICTreeNodeIncludedTreeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
