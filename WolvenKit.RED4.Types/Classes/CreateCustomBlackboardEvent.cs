using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CreateCustomBlackboardEvent : redEvent
	{
		private CHandle<CustomBlackboardDef> _blackboardDef;
		private CWeakHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("blackboardDef")] 
		public CHandle<CustomBlackboardDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}
	}
}
