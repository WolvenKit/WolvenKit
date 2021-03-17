using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interactionWidgetGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private wCHandle<inkTextWidget> _titleLabel;
		private wCHandle<inkWidget> _titleBorder;
		private wCHandle<inkHorizontalPanelWidget> _optionsList;
		private CArray<wCHandle<inkWidget>> _widgetsPool;
		private CHandle<gameIBlackboard> _bbInteraction;
		private CHandle<gameIBlackboard> _bbPlayerStateMachine;
		private CHandle<UIInteractionsDef> _bbInteractionDefinition;
		private CUInt32 _updateInteractionId;
		private CUInt32 _activeHubListenerId;
		private CUInt32 _contactsActiveListenerId;
		private CInt32 _id;
		private CBool _isActive;
		private CBool _areContactsOpen;
		private inkWidgetReference _progressBarHolder;
		private CHandle<DialogChoiceTimerController> _progressBar;
		private CBool _hasProgressBar;
		private CHandle<gameIBlackboard> _bb;
		private CHandle<UIInteractionsDef> _bbUIInteractionsDef;
		private CUInt32 _bbLastAttemptedChoiceCallbackId;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("titleLabel")] 
		public wCHandle<inkTextWidget> TitleLabel
		{
			get => GetProperty(ref _titleLabel);
			set => SetProperty(ref _titleLabel, value);
		}

		[Ordinal(11)] 
		[RED("titleBorder")] 
		public wCHandle<inkWidget> TitleBorder
		{
			get => GetProperty(ref _titleBorder);
			set => SetProperty(ref _titleBorder, value);
		}

		[Ordinal(12)] 
		[RED("optionsList")] 
		public wCHandle<inkHorizontalPanelWidget> OptionsList
		{
			get => GetProperty(ref _optionsList);
			set => SetProperty(ref _optionsList, value);
		}

		[Ordinal(13)] 
		[RED("widgetsPool")] 
		public CArray<wCHandle<inkWidget>> WidgetsPool
		{
			get => GetProperty(ref _widgetsPool);
			set => SetProperty(ref _widgetsPool, value);
		}

		[Ordinal(14)] 
		[RED("bbInteraction")] 
		public CHandle<gameIBlackboard> BbInteraction
		{
			get => GetProperty(ref _bbInteraction);
			set => SetProperty(ref _bbInteraction, value);
		}

		[Ordinal(15)] 
		[RED("bbPlayerStateMachine")] 
		public CHandle<gameIBlackboard> BbPlayerStateMachine
		{
			get => GetProperty(ref _bbPlayerStateMachine);
			set => SetProperty(ref _bbPlayerStateMachine, value);
		}

		[Ordinal(16)] 
		[RED("bbInteractionDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionDefinition
		{
			get => GetProperty(ref _bbInteractionDefinition);
			set => SetProperty(ref _bbInteractionDefinition, value);
		}

		[Ordinal(17)] 
		[RED("updateInteractionId")] 
		public CUInt32 UpdateInteractionId
		{
			get => GetProperty(ref _updateInteractionId);
			set => SetProperty(ref _updateInteractionId, value);
		}

		[Ordinal(18)] 
		[RED("activeHubListenerId")] 
		public CUInt32 ActiveHubListenerId
		{
			get => GetProperty(ref _activeHubListenerId);
			set => SetProperty(ref _activeHubListenerId, value);
		}

		[Ordinal(19)] 
		[RED("contactsActiveListenerId")] 
		public CUInt32 ContactsActiveListenerId
		{
			get => GetProperty(ref _contactsActiveListenerId);
			set => SetProperty(ref _contactsActiveListenerId, value);
		}

		[Ordinal(20)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(21)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(22)] 
		[RED("areContactsOpen")] 
		public CBool AreContactsOpen
		{
			get => GetProperty(ref _areContactsOpen);
			set => SetProperty(ref _areContactsOpen, value);
		}

		[Ordinal(23)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get => GetProperty(ref _progressBarHolder);
			set => SetProperty(ref _progressBarHolder, value);
		}

		[Ordinal(24)] 
		[RED("progressBar")] 
		public CHandle<DialogChoiceTimerController> ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(25)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get => GetProperty(ref _hasProgressBar);
			set => SetProperty(ref _hasProgressBar, value);
		}

		[Ordinal(26)] 
		[RED("bb")] 
		public CHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(27)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get => GetProperty(ref _bbUIInteractionsDef);
			set => SetProperty(ref _bbUIInteractionsDef, value);
		}

		[Ordinal(28)] 
		[RED("bbLastAttemptedChoiceCallbackId")] 
		public CUInt32 BbLastAttemptedChoiceCallbackId
		{
			get => GetProperty(ref _bbLastAttemptedChoiceCallbackId);
			set => SetProperty(ref _bbLastAttemptedChoiceCallbackId, value);
		}

		public interactionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
