using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParallelNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		private CEnum<AIbehaviorParallelNodeWaitFor> _waitFor;

		[Ordinal(1)] 
		[RED("waitFor")] 
		public CEnum<AIbehaviorParallelNodeWaitFor> WaitFor
		{
			get => GetProperty(ref _waitFor);
			set => SetProperty(ref _waitFor, value);
		}

		public AIbehaviorParallelNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
