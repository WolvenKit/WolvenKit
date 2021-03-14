using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InjectCombatTargetCommandTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIInjectCombatTargetCommand> _currentCommand;
		private CFloat _activationTimeStamp;
		private CFloat _commandDuration;
		private wCHandle<gameObject> _target;
		private entEntityID _targetID;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get
			{
				if (_inCommand == null)
				{
					_inCommand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inCommand", cr2w, this);
				}
				return _inCommand;
			}
			set
			{
				if (_inCommand == value)
				{
					return;
				}
				_inCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public wCHandle<AIInjectCombatTargetCommand> CurrentCommand
		{
			get
			{
				if (_currentCommand == null)
				{
					_currentCommand = (wCHandle<AIInjectCombatTargetCommand>) CR2WTypeManager.Create("whandle:AIInjectCombatTargetCommand", "currentCommand", cr2w, this);
				}
				return _currentCommand;
			}
			set
			{
				if (_currentCommand == value)
				{
					return;
				}
				_currentCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get
			{
				if (_activationTimeStamp == null)
				{
					_activationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "activationTimeStamp", cr2w, this);
				}
				return _activationTimeStamp;
			}
			set
			{
				if (_activationTimeStamp == value)
				{
					return;
				}
				_activationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("commandDuration")] 
		public CFloat CommandDuration
		{
			get
			{
				if (_commandDuration == null)
				{
					_commandDuration = (CFloat) CR2WTypeManager.Create("Float", "commandDuration", cr2w, this);
				}
				return _commandDuration;
			}
			set
			{
				if (_commandDuration == value)
				{
					return;
				}
				_commandDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		public InjectCombatTargetCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
