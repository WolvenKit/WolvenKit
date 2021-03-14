using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCombatModeTaskDefinition : AIbehaviorTaskDefinition
	{
		private CEnum<AIbehaviorCombatModes> _mode;
		private CInt32 _priority;
		private CFloat _timeToLive;

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<AIbehaviorCombatModes> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<AIbehaviorCombatModes>) CR2WTypeManager.Create("AIbehaviorCombatModes", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get
			{
				if (_timeToLive == null)
				{
					_timeToLive = (CFloat) CR2WTypeManager.Create("Float", "timeToLive", cr2w, this);
				}
				return _timeToLive;
			}
			set
			{
				if (_timeToLive == value)
				{
					return;
				}
				_timeToLive = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCombatModeTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
