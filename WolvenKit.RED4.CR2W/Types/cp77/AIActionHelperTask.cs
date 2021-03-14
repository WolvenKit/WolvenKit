using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionHelperTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;
		private CString _actionStringName;
		private CBool _initialized;
		private CName _actionName;
		private TweakDBID _actionID;

		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get
			{
				if (_actionTweakIDMapping == null)
				{
					_actionTweakIDMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "actionTweakIDMapping", cr2w, this);
				}
				return _actionTweakIDMapping;
			}
			set
			{
				if (_actionTweakIDMapping == value)
				{
					return;
				}
				_actionTweakIDMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionStringName")] 
		public CString ActionStringName
		{
			get
			{
				if (_actionStringName == null)
				{
					_actionStringName = (CString) CR2WTypeManager.Create("String", "actionStringName", cr2w, this);
				}
				return _actionStringName;
			}
			set
			{
				if (_actionStringName == value)
				{
					return;
				}
				_actionStringName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CBool) CR2WTypeManager.Create("Bool", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		public AIActionHelperTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
