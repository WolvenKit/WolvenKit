using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRepeatNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _limit;
		private CBool _repeatChildOnFailure;

		[Ordinal(1)] 
		[RED("limit")] 
		public CHandle<AIArgumentMapping> Limit
		{
			get
			{
				if (_limit == null)
				{
					_limit = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "limit", cr2w, this);
				}
				return _limit;
			}
			set
			{
				if (_limit == value)
				{
					return;
				}
				_limit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("repeatChildOnFailure")] 
		public CBool RepeatChildOnFailure
		{
			get
			{
				if (_repeatChildOnFailure == null)
				{
					_repeatChildOnFailure = (CBool) CR2WTypeManager.Create("Bool", "repeatChildOnFailure", cr2w, this);
				}
				return _repeatChildOnFailure;
			}
			set
			{
				if (_repeatChildOnFailure == value)
				{
					return;
				}
				_repeatChildOnFailure = value;
				PropertySet(this);
			}
		}

		public AIbehaviorRepeatNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
