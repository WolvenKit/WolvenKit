using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseScriptableAction : gamedeviceAction
	{
		private entEntityID _requesterID;
		private wCHandle<gameObject> _executor;
		private TweakDBID _objectActionID;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private TweakDBID _inkWidgetID;
		private gameinteractionsChoice _interactionChoice;
		private CName _interactionLayer;
		private CBool _isActionRPGCheckDissabled;

		[Ordinal(3)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requesterID", cr2w, this);
				}
				return _requesterID;
			}
			set
			{
				if (_requesterID == value)
				{
					return;
				}
				_requesterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get
			{
				if (_executor == null)
				{
					_executor = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "executor", cr2w, this);
				}
				return _executor;
			}
			set
			{
				if (_executor == value)
				{
					return;
				}
				_executor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get
			{
				if (_objectActionID == null)
				{
					_objectActionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "objectActionID", cr2w, this);
				}
				return _objectActionID;
			}
			set
			{
				if (_objectActionID == value)
				{
					return;
				}
				_objectActionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get
			{
				if (_objectActionRecord == null)
				{
					_objectActionRecord = (wCHandle<gamedataObjectAction_Record>) CR2WTypeManager.Create("whandle:gamedataObjectAction_Record", "objectActionRecord", cr2w, this);
				}
				return _objectActionRecord;
			}
			set
			{
				if (_objectActionRecord == value)
				{
					return;
				}
				_objectActionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inkWidgetID")] 
		public TweakDBID InkWidgetID
		{
			get
			{
				if (_inkWidgetID == null)
				{
					_inkWidgetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "inkWidgetID", cr2w, this);
				}
				return _inkWidgetID;
			}
			set
			{
				if (_inkWidgetID == value)
				{
					return;
				}
				_inkWidgetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("interactionChoice")] 
		public gameinteractionsChoice InteractionChoice
		{
			get
			{
				if (_interactionChoice == null)
				{
					_interactionChoice = (gameinteractionsChoice) CR2WTypeManager.Create("gameinteractionsChoice", "interactionChoice", cr2w, this);
				}
				return _interactionChoice;
			}
			set
			{
				if (_interactionChoice == value)
				{
					return;
				}
				_interactionChoice = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("interactionLayer")] 
		public CName InteractionLayer
		{
			get
			{
				if (_interactionLayer == null)
				{
					_interactionLayer = (CName) CR2WTypeManager.Create("CName", "interactionLayer", cr2w, this);
				}
				return _interactionLayer;
			}
			set
			{
				if (_interactionLayer == value)
				{
					return;
				}
				_interactionLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isActionRPGCheckDissabled")] 
		public CBool IsActionRPGCheckDissabled
		{
			get
			{
				if (_isActionRPGCheckDissabled == null)
				{
					_isActionRPGCheckDissabled = (CBool) CR2WTypeManager.Create("Bool", "isActionRPGCheckDissabled", cr2w, this);
				}
				return _isActionRPGCheckDissabled;
			}
			set
			{
				if (_isActionRPGCheckDissabled == value)
				{
					return;
				}
				_isActionRPGCheckDissabled = value;
				PropertySet(this);
			}
		}

		public BaseScriptableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
