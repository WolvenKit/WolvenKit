using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _completeWhenRotated;

		[Ordinal(5)] 
		[RED("completeWhenRotated")] 
		public CHandle<AIArgumentMapping> CompleteWhenRotated
		{
			get => GetProperty(ref _completeWhenRotated);
			set => SetProperty(ref _completeWhenRotated, value);
		}

		public AIbehaviorActionRotateToObjectTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
