using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CHandle<AIBackgroundCombatCommand> _command;
		private CBool _execute;
		private CArray<AIBackgroundCombatStep> _steps;
		private CInt32 _currentStep;
		private NodeRef _desiredCover;
		private CEnum<AICoverExposureMethod> _desiredCoverExposureMethod;
		private NodeRef _desiredDestination;
		private CBool _hasDesiredTarget;
		private gameEntityReference _desiredTarget;
		private CUInt64 _desiredCoverId;
		private CUInt64 _currentCoverId;
		private wCHandle<gameObject> _currentTarget;
		private CBool _canFireFromCover;
		private CBool _canFireOutOfCover;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIBackgroundCombatCommand> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (CHandle<AIBackgroundCombatCommand>) CR2WTypeManager.Create("handle:AIBackgroundCombatCommand", "command", cr2w, this);
				}
				return _command;
			}
			set
			{
				if (_command == value)
				{
					return;
				}
				_command = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("execute")] 
		public CBool Execute
		{
			get
			{
				if (_execute == null)
				{
					_execute = (CBool) CR2WTypeManager.Create("Bool", "execute", cr2w, this);
				}
				return _execute;
			}
			set
			{
				if (_execute == value)
				{
					return;
				}
				_execute = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get
			{
				if (_steps == null)
				{
					_steps = (CArray<AIBackgroundCombatStep>) CR2WTypeManager.Create("array:AIBackgroundCombatStep", "steps", cr2w, this);
				}
				return _steps;
			}
			set
			{
				if (_steps == value)
				{
					return;
				}
				_steps = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentStep")] 
		public CInt32 CurrentStep
		{
			get
			{
				if (_currentStep == null)
				{
					_currentStep = (CInt32) CR2WTypeManager.Create("Int32", "currentStep", cr2w, this);
				}
				return _currentStep;
			}
			set
			{
				if (_currentStep == value)
				{
					return;
				}
				_currentStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("desiredCover")] 
		public NodeRef DesiredCover
		{
			get
			{
				if (_desiredCover == null)
				{
					_desiredCover = (NodeRef) CR2WTypeManager.Create("NodeRef", "desiredCover", cr2w, this);
				}
				return _desiredCover;
			}
			set
			{
				if (_desiredCover == value)
				{
					return;
				}
				_desiredCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("desiredCoverExposureMethod")] 
		public CEnum<AICoverExposureMethod> DesiredCoverExposureMethod
		{
			get
			{
				if (_desiredCoverExposureMethod == null)
				{
					_desiredCoverExposureMethod = (CEnum<AICoverExposureMethod>) CR2WTypeManager.Create("AICoverExposureMethod", "desiredCoverExposureMethod", cr2w, this);
				}
				return _desiredCoverExposureMethod;
			}
			set
			{
				if (_desiredCoverExposureMethod == value)
				{
					return;
				}
				_desiredCoverExposureMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desiredDestination")] 
		public NodeRef DesiredDestination
		{
			get
			{
				if (_desiredDestination == null)
				{
					_desiredDestination = (NodeRef) CR2WTypeManager.Create("NodeRef", "desiredDestination", cr2w, this);
				}
				return _desiredDestination;
			}
			set
			{
				if (_desiredDestination == value)
				{
					return;
				}
				_desiredDestination = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hasDesiredTarget")] 
		public CBool HasDesiredTarget
		{
			get
			{
				if (_hasDesiredTarget == null)
				{
					_hasDesiredTarget = (CBool) CR2WTypeManager.Create("Bool", "hasDesiredTarget", cr2w, this);
				}
				return _hasDesiredTarget;
			}
			set
			{
				if (_hasDesiredTarget == value)
				{
					return;
				}
				_hasDesiredTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("desiredTarget")] 
		public gameEntityReference DesiredTarget
		{
			get
			{
				if (_desiredTarget == null)
				{
					_desiredTarget = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "desiredTarget", cr2w, this);
				}
				return _desiredTarget;
			}
			set
			{
				if (_desiredTarget == value)
				{
					return;
				}
				_desiredTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("desiredCoverId")] 
		public CUInt64 DesiredCoverId
		{
			get
			{
				if (_desiredCoverId == null)
				{
					_desiredCoverId = (CUInt64) CR2WTypeManager.Create("Uint64", "desiredCoverId", cr2w, this);
				}
				return _desiredCoverId;
			}
			set
			{
				if (_desiredCoverId == value)
				{
					return;
				}
				_desiredCoverId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentCoverId")] 
		public CUInt64 CurrentCoverId
		{
			get
			{
				if (_currentCoverId == null)
				{
					_currentCoverId = (CUInt64) CR2WTypeManager.Create("Uint64", "currentCoverId", cr2w, this);
				}
				return _currentCoverId;
			}
			set
			{
				if (_currentCoverId == value)
				{
					return;
				}
				_currentCoverId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("currentTarget")] 
		public wCHandle<gameObject> CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("canFireFromCover")] 
		public CBool CanFireFromCover
		{
			get
			{
				if (_canFireFromCover == null)
				{
					_canFireFromCover = (CBool) CR2WTypeManager.Create("Bool", "canFireFromCover", cr2w, this);
				}
				return _canFireFromCover;
			}
			set
			{
				if (_canFireFromCover == value)
				{
					return;
				}
				_canFireFromCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("canFireOutOfCover")] 
		public CBool CanFireOutOfCover
		{
			get
			{
				if (_canFireOutOfCover == null)
				{
					_canFireOutOfCover = (CBool) CR2WTypeManager.Create("Bool", "canFireOutOfCover", cr2w, this);
				}
				return _canFireOutOfCover;
			}
			set
			{
				if (_canFireOutOfCover == value)
				{
					return;
				}
				_canFireOutOfCover = value;
				PropertySet(this);
			}
		}

		public AIBackgroundCombatDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
