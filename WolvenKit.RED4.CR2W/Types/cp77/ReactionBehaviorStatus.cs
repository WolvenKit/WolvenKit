using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionBehaviorStatus : redEvent
	{
		private CEnum<AIbehaviorUpdateOutcome> _status;
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<AIbehaviorUpdateOutcome> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetProperty(ref _reactionData);
			set => SetProperty(ref _reactionData, value);
		}

		public ReactionBehaviorStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
