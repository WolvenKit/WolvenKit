using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CBool _lateInitialization;
		private CArray<CName> _initializeOnEvent;

		[Ordinal(0)] 
		[RED("lateInitialization")] 
		public CBool LateInitialization
		{
			get => GetProperty(ref _lateInitialization);
			set => SetProperty(ref _lateInitialization, value);
		}

		[Ordinal(1)] 
		[RED("initializeOnEvent")] 
		public CArray<CName> InitializeOnEvent
		{
			get => GetProperty(ref _initializeOnEvent);
			set => SetProperty(ref _initializeOnEvent, value);
		}

		public AIbehaviorNestedTreeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
