using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveEventTagConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		private CName _tag;
		private CBool _deactivateEvents;

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(2)] 
		[RED("deactivateEvents")] 
		public CBool DeactivateEvents
		{
			get => GetProperty(ref _deactivateEvents);
			set => SetProperty(ref _deactivateEvents, value);
		}

		public AIbehaviorPassiveEventTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
