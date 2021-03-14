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
			get
			{
				if (_status == null)
				{
					_status = (CEnum<AIbehaviorUpdateOutcome>) CR2WTypeManager.Create("AIbehaviorUpdateOutcome", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get
			{
				if (_reactionData == null)
				{
					_reactionData = (CHandle<AIReactionData>) CR2WTypeManager.Create("handle:AIReactionData", "reactionData", cr2w, this);
				}
				return _reactionData;
			}
			set
			{
				if (_reactionData == value)
				{
					return;
				}
				_reactionData = value;
				PropertySet(this);
			}
		}

		public ReactionBehaviorStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
