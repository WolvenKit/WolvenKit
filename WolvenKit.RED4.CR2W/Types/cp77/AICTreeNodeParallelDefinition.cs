using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeParallelDefinition : AICTreeNodeChildrenListDefinition
	{
		private CBool _forwardChildrenCompleteness;

		[Ordinal(1)] 
		[RED("forwardChildrenCompleteness")] 
		public CBool ForwardChildrenCompleteness
		{
			get => GetProperty(ref _forwardChildrenCompleteness);
			set => SetProperty(ref _forwardChildrenCompleteness, value);
		}

		public AICTreeNodeParallelDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
