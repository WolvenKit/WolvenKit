using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		private CName _tag;
		private CBool _consumeEvent;

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("consumeEvent")] 
		public CBool ConsumeEvent
		{
			get
			{
				if (_consumeEvent == null)
				{
					_consumeEvent = (CBool) CR2WTypeManager.Create("Bool", "consumeEvent", cr2w, this);
				}
				return _consumeEvent;
			}
			set
			{
				if (_consumeEvent == value)
				{
					return;
				}
				_consumeEvent = value;
				PropertySet(this);
			}
		}

		public AIbehaviorEventWithTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
