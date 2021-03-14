using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CreateCustomBlackboardEvent : redEvent
	{
		private CHandle<CustomBlackboardDef> _blackboardDef;
		private CHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("blackboardDef")] 
		public CHandle<CustomBlackboardDef> BlackboardDef
		{
			get
			{
				if (_blackboardDef == null)
				{
					_blackboardDef = (CHandle<CustomBlackboardDef>) CR2WTypeManager.Create("handle:CustomBlackboardDef", "blackboardDef", cr2w, this);
				}
				return _blackboardDef;
			}
			set
			{
				if (_blackboardDef == value)
				{
					return;
				}
				_blackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		public CreateCustomBlackboardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
