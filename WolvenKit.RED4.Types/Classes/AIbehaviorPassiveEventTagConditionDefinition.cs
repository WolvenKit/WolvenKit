using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorPassiveEventTagConditionDefinition : AIbehaviorPassiveConditionDefinition
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
	}
}
