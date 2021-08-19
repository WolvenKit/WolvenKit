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
		private CArray<Vector4> _investigationPositionsArray;
		private wCHandle<gameIBlackboard> _actionRestrictionPlayerBB;
		private CHandle<redCallbackObject> _actionRestrictionCallbackID;

		[Ordinal(87)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(88)] 
		[RED("interactionIndicator")] 
		public CHandle<gameLightComponent> InteractionIndicator
		{
			get => GetProperty(ref _interactionIndicator);
			set => SetProperty(ref _interactionIndicator, value);
		}

		[Ordinal(89)] 
		[RED("disableAreaIndicatorID")] 
		public gameDelayID DisableAreaIndicatorID
		{
			get => GetProperty(ref _disableAreaIndicatorID);
			set => SetProperty(ref _disableAreaIndicatorID, value);
		}

		[Ordinal(90)] 
		[RED("delayedUIRefreshID")] 
		public gameDelayID DelayedUIRefreshID
		{
			get => GetProperty(ref _delayedUIRefreshID);
			set => SetProperty(ref _delayedUIRefreshID, value);
		}

		[Ordinal(91)] 
		[RED("isPlayerAround")] 
		public CBool IsPlayerAround
		{
			get => GetProperty(ref _isPlayerAround);
			set => SetProperty(ref _isPlayerAround, value);
		}

		[Ordinal(92)] 
		[RED("disableAreaIndicatorDelayActive")] 
		public CBool DisableAreaIndicatorDelayActive
		{
			get => GetProperty(ref _disableAreaIndicatorDelayActive);
			set => SetProperty(ref _disableAreaIndicatorDelayActive, value);
		}

		[Ordinal(93)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetProperty(ref _objectActionsCallbackCtrl);
			set => SetProperty(ref _objectActionsCallbackCtrl, value);
		}

		[Ordinal(94)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetProperty(ref _investigationPositionsArray);
			set => SetProperty(ref _investigationPositionsArray, value);
		}

		[Ordinal(95)] 
		[RED("actionRestrictionPlayerBB")] 
		public wCHandle<gameIBlackboard> ActionRestrictionPlayerBB
		{
			get => GetProperty(ref _actionRestrictionPlayerBB);
			set => SetProperty(ref _actionRestrictionPlayerBB, value);
		}

		[Ordinal(96)] 
		[RED("actionRestrictionCallbackID")] 
		public CHandle<redCallbackObject> ActionRestrictionCallbackID
		{
			get => GetProperty(ref _actionRestrictionCallbackID);
			set => SetProperty(ref _actionRestrictionCallbackID, value);
		}

		public InteractiveDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
