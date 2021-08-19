using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTweakConditionDefinition : AIbehaviorConditionDefinition
	{
		private TweakDBID _recordId;

		[Ordinal(1)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetProperty(ref _recordId);
			set => SetProperty(ref _recordId, value);
		}

		public AIbehaviorTweakConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
