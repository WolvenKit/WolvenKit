using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeBrainDefinition : AICTreeNodeCompositeDefinition
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

		public AICTreeNodeBrainDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
