using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
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
	}
}
