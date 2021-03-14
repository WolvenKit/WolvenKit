using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		private CName _signalName;
		private CEnum<AIbehaviorSignalConditionModes> _mode;
		private CBool _tagSignal;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get
			{
				if (_signalName == null)
				{
					_signalName = (CName) CR2WTypeManager.Create("CName", "signalName", cr2w, this);
				}
				return _signalName;
			}
			set
			{
				if (_signalName == value)
				{
					return;
				}
				_signalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<AIbehaviorSignalConditionModes> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<AIbehaviorSignalConditionModes>) CR2WTypeManager.Create("AIbehaviorSignalConditionModes", "mode", cr2w, this);
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

		[Ordinal(3)] 
		[RED("tagSignal")] 
		public CBool TagSignal
		{
			get
			{
				if (_tagSignal == null)
				{
					_tagSignal = (CBool) CR2WTypeManager.Create("Bool", "tagSignal", cr2w, this);
				}
				return _tagSignal;
			}
			set
			{
				if (_tagSignal == value)
				{
					return;
				}
				_tagSignal = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSignalConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
