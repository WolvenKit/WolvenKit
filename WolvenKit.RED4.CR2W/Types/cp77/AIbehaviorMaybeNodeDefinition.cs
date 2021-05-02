using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CEnum<AIbehaviorMaybeNodeAction> _onChildSuccess;
		private CEnum<AIbehaviorMaybeNodeAction> _onChildFailure;

		[Ordinal(1)] 
		[RED("onChildSuccess")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess
		{
			get => GetProperty(ref _onChildSuccess);
			set => SetProperty(ref _onChildSuccess, value);
		}

		[Ordinal(2)] 
		[RED("onChildFailure")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure
		{
			get => GetProperty(ref _onChildFailure);
			set => SetProperty(ref _onChildFailure, value);
		}

		public AIbehaviorMaybeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
