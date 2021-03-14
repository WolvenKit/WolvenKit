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
		[RED("deactivateEvents")] 
		public CBool DeactivateEvents
		{
			get
			{
				if (_deactivateEvents == null)
				{
					_deactivateEvents = (CBool) CR2WTypeManager.Create("Bool", "deactivateEvents", cr2w, this);
				}
				return _deactivateEvents;
			}
			set
			{
				if (_deactivateEvents == value)
				{
					return;
				}
				_deactivateEvents = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPassiveEventTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
