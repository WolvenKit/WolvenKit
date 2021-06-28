using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecoratorDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _child;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}

		public AICTreeNodeDecoratorDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
