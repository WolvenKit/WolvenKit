using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CreateCustomBlackboardEvent : redEvent
	{
		private CHandle<CustomBlackboardDef> _blackboardDef;
		private wCHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("blackboardDef")] 
		public CHandle<CustomBlackboardDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public CreateCustomBlackboardEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
