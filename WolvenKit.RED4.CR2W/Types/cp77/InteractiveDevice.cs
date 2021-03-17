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
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(87)] 
		[RED("interactionIndicator")] 
		public CHandle<gameLightComponent> InteractionIndicator
		{
			get => GetProperty(ref _interactionIndicator);
			set => SetProperty(ref _interactionIndicator, value);
		}

		[Ordinal(88)] 
		[RED("disableAreaIndicatorID")] 
		public gameDelayID DisableAreaIndicatorID
		{
			get => GetProperty(ref _disableAreaIndicatorID);
			set => SetProperty(ref _disableAreaIndicatorID, value);
		}

		[Ordinal(89)] 
		[RED("delayedUIRefreshID")] 
		public gameDelayID DelayedUIRefreshID
		{
			get => GetProperty(ref _delayedUIRefreshID);
			set => SetProperty(ref _delayedUIRefreshID, value);
		}

		[Ordinal(90)] 
		[RED("isPlayerAround")] 
		public CBool IsPlayerAround
		{
			get => GetProperty(ref _isPlayerAround);
			set => SetProperty(ref _isPlayerAround, value);
		}

		[Ordinal(91)] 
		[RED("disableAreaIndicatorDelayActive")] 
		public CBool DisableAreaIndicatorDelayActive
		{
			get => GetProperty(ref _disableAreaIndicatorDelayActive);
			set => SetProperty(ref _disableAreaIndicatorDelayActive, value);
		}

		[Ordinal(92)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetProperty(ref _objectActionsCallbackCtrl);
			set => SetProperty(ref _objectActionsCallbackCtrl, value);
		}

		public InteractiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
