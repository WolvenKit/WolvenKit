using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerTask : AIbehaviortaskScript
	{
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
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

		public ReactionManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
