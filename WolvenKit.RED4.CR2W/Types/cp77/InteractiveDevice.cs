using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveDevice : Device
	{
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<gameLightComponent> _interactionIndicator;
		private gameDelayID _disableAreaIndicatorID;
		private gameDelayID _delayedUIRefreshID;
		private CBool _isPlayerAround;
		private CBool _disableAreaIndicatorDelayActive;
		private CHandle<gameObjectActionsCallbackController> _objectActionsCallbackCtrl;

		[Ordinal(86)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get
			{
				if (_interaction == null)
				{
					_interaction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interaction", cr2w, this);
				}
				return _interaction;
			}
			set
			{
				if (_interaction == value)
				{
					return;
				}
				_interaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("interactionIndicator")] 
		public CHandle<gameLightComponent> InteractionIndicator
		{
			get
			{
				if (_interactionIndicator == null)
				{
					_interactionIndicator = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "interactionIndicator", cr2w, this);
				}
				return _interactionIndicator;
			}
			set
			{
				if (_interactionIndicator == value)
				{
					return;
				}
				_interactionIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("disableAreaIndicatorID")] 
		public gameDelayID DisableAreaIndicatorID
		{
			get
			{
				if (_disableAreaIndicatorID == null)
				{
					_disableAreaIndicatorID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "disableAreaIndicatorID", cr2w, this);
				}
				return _disableAreaIndicatorID;
			}
			set
			{
				if (_disableAreaIndicatorID == value)
				{
					return;
				}
				_disableAreaIndicatorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("delayedUIRefreshID")] 
		public gameDelayID DelayedUIRefreshID
		{
			get
			{
				if (_delayedUIRefreshID == null)
				{
					_delayedUIRefreshID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayedUIRefreshID", cr2w, this);
				}
				return _delayedUIRefreshID;
			}
			set
			{
				if (_delayedUIRefreshID == value)
				{
					return;
				}
				_delayedUIRefreshID = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("isPlayerAround")] 
		public CBool IsPlayerAround
		{
			get
			{
				if (_isPlayerAround == null)
				{
					_isPlayerAround = (CBool) CR2WTypeManager.Create("Bool", "isPlayerAround", cr2w, this);
				}
				return _isPlayerAround;
			}
			set
			{
				if (_isPlayerAround == value)
				{
					return;
				}
				_isPlayerAround = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("disableAreaIndicatorDelayActive")] 
		public CBool DisableAreaIndicatorDelayActive
		{
			get
			{
				if (_disableAreaIndicatorDelayActive == null)
				{
					_disableAreaIndicatorDelayActive = (CBool) CR2WTypeManager.Create("Bool", "disableAreaIndicatorDelayActive", cr2w, this);
				}
				return _disableAreaIndicatorDelayActive;
			}
			set
			{
				if (_disableAreaIndicatorDelayActive == value)
				{
					return;
				}
				_disableAreaIndicatorDelayActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get
			{
				if (_objectActionsCallbackCtrl == null)
				{
					_objectActionsCallbackCtrl = (CHandle<gameObjectActionsCallbackController>) CR2WTypeManager.Create("handle:gameObjectActionsCallbackController", "objectActionsCallbackCtrl", cr2w, this);
				}
				return _objectActionsCallbackCtrl;
			}
			set
			{
				if (_objectActionsCallbackCtrl == value)
				{
					return;
				}
				_objectActionsCallbackCtrl = value;
				PropertySet(this);
			}
		}

		public InteractiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
