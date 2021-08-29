using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDeviceActionData : RedBaseClass
	{
		private CBool _hasInteraction;
		private CBool _hasUI;
		private CBool _isQuickHack;
		private CBool _isSpiderbotAction;
		private NodeRef _spiderbotLocationOverrideReference;
		private CEnum<EDeviceChallengeSkill> _attachedToSkillCheck;
		private TweakDBID _widgetRecord;
		private TweakDBID _objectActionRecord;
		private CName _currentDisplayName;
		private CString _interactionRecord;

		[Ordinal(0)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetProperty(ref _hasInteraction);
			set => SetProperty(ref _hasInteraction, value);
		}

		[Ordinal(1)] 
		[RED("hasUI")] 
		public CBool HasUI
		{
			get => GetProperty(ref _hasUI);
			set => SetProperty(ref _hasUI, value);
		}

		[Ordinal(2)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetProperty(ref _isQuickHack);
			set => SetProperty(ref _isQuickHack, value);
		}

		[Ordinal(3)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetProperty(ref _isSpiderbotAction);
			set => SetProperty(ref _isSpiderbotAction, value);
		}

		[Ordinal(4)] 
		[RED("spiderbotLocationOverrideReference")] 
		public NodeRef SpiderbotLocationOverrideReference
		{
			get => GetProperty(ref _spiderbotLocationOverrideReference);
			set => SetProperty(ref _spiderbotLocationOverrideReference, value);
		}

		[Ordinal(5)] 
		[RED("attachedToSkillCheck")] 
		public CEnum<EDeviceChallengeSkill> AttachedToSkillCheck
		{
			get => GetProperty(ref _attachedToSkillCheck);
			set => SetProperty(ref _attachedToSkillCheck, value);
		}

		[Ordinal(6)] 
		[RED("widgetRecord")] 
		public TweakDBID WidgetRecord
		{
			get => GetProperty(ref _widgetRecord);
			set => SetProperty(ref _widgetRecord, value);
		}

		[Ordinal(7)] 
		[RED("objectActionRecord")] 
		public TweakDBID ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(8)] 
		[RED("currentDisplayName")] 
		public CName CurrentDisplayName
		{
			get => GetProperty(ref _currentDisplayName);
			set => SetProperty(ref _currentDisplayName, value);
		}

		[Ordinal(9)] 
		[RED("interactionRecord")] 
		public CString InteractionRecord
		{
			get => GetProperty(ref _interactionRecord);
			set => SetProperty(ref _interactionRecord, value);
		}
	}
}
