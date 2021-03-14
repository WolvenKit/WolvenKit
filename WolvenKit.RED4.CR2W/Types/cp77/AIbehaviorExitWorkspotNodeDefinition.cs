using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExitWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _skipExitAnimation;
		private CHandle<AIArgumentMapping> _useSlowExitAnimation;
		private CHandle<AIArgumentMapping> _doSlowIfFastExitFails;
		private CHandle<AIArgumentMapping> _stayInWorkspotIfExitFails;
		private CHandle<AIArgumentMapping> _tryBlendFastExitToWalk;
		private CHandle<AIArgumentMapping> _dontRequestExit;
		private CHandle<AIArgumentMapping> _target;

		[Ordinal(1)] 
		[RED("skipExitAnimation")] 
		public CHandle<AIArgumentMapping> SkipExitAnimation
		{
			get
			{
				if (_skipExitAnimation == null)
				{
					_skipExitAnimation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "skipExitAnimation", cr2w, this);
				}
				return _skipExitAnimation;
			}
			set
			{
				if (_skipExitAnimation == value)
				{
					return;
				}
				_skipExitAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useSlowExitAnimation")] 
		public CHandle<AIArgumentMapping> UseSlowExitAnimation
		{
			get
			{
				if (_useSlowExitAnimation == null)
				{
					_useSlowExitAnimation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useSlowExitAnimation", cr2w, this);
				}
				return _useSlowExitAnimation;
			}
			set
			{
				if (_useSlowExitAnimation == value)
				{
					return;
				}
				_useSlowExitAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doSlowIfFastExitFails")] 
		public CHandle<AIArgumentMapping> DoSlowIfFastExitFails
		{
			get
			{
				if (_doSlowIfFastExitFails == null)
				{
					_doSlowIfFastExitFails = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "doSlowIfFastExitFails", cr2w, this);
				}
				return _doSlowIfFastExitFails;
			}
			set
			{
				if (_doSlowIfFastExitFails == value)
				{
					return;
				}
				_doSlowIfFastExitFails = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stayInWorkspotIfExitFails")] 
		public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails
		{
			get
			{
				if (_stayInWorkspotIfExitFails == null)
				{
					_stayInWorkspotIfExitFails = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stayInWorkspotIfExitFails", cr2w, this);
				}
				return _stayInWorkspotIfExitFails;
			}
			set
			{
				if (_stayInWorkspotIfExitFails == value)
				{
					return;
				}
				_stayInWorkspotIfExitFails = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tryBlendFastExitToWalk")] 
		public CHandle<AIArgumentMapping> TryBlendFastExitToWalk
		{
			get
			{
				if (_tryBlendFastExitToWalk == null)
				{
					_tryBlendFastExitToWalk = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "tryBlendFastExitToWalk", cr2w, this);
				}
				return _tryBlendFastExitToWalk;
			}
			set
			{
				if (_tryBlendFastExitToWalk == value)
				{
					return;
				}
				_tryBlendFastExitToWalk = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dontRequestExit")] 
		public CHandle<AIArgumentMapping> DontRequestExit
		{
			get
			{
				if (_dontRequestExit == null)
				{
					_dontRequestExit = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "dontRequestExit", cr2w, this);
				}
				return _dontRequestExit;
			}
			set
			{
				if (_dontRequestExit == value)
				{
					return;
				}
				_dontRequestExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
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

		public AIbehaviorExitWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
