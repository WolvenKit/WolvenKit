using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObjectiveEntryLogicController : inkWidgetLogicController
	{
		private CFloat _blinkInterval;
		private CFloat _blinkTotalTime;
		private CName _texturePart_Tracked;
		private CName _texturePart_Untracked;
		private CName _texturePart_Succeeded;
		private CName _texturePart_Failed;
		private CBool _isLargeUpdateWidget;
		private CWeakHandle<inkTextWidget> _entryName;
		private CWeakHandle<inkTextWidget> _entryOptional;
		private CWeakHandle<inkImageWidget> _stateIcon;
		private CWeakHandle<inkImageWidget> _trackedIcon;
		private CWeakHandle<inkWidget> _blinkWidget;
		private CWeakHandle<inkWidget> _root;
		private CHandle<inkanimDefinition> _animBlinkDef;
		private CHandle<inkanimProxy> _animBlink;
		private CHandle<inkanimDefinition> _animFadeDef;
		private CHandle<inkanimProxy> _animFade;
		private CInt32 _entryId;
		private CEnum<UIObjectiveEntryType> _type;
		private CEnum<gameJournalEntryState> _state;
		private CWeakHandle<ObjectiveEntryLogicController> _parentEntry;
		private CInt32 _childCount;
		private CBool _updated;
		private CBool _isTracked;
		private CBool _isOptional;

		[Ordinal(1)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetProperty(ref _blinkInterval);
			set => SetProperty(ref _blinkInterval, value);
		}

		[Ordinal(2)] 
		[RED("blinkTotalTime")] 
		public CFloat BlinkTotalTime
		{
			get => GetProperty(ref _blinkTotalTime);
			set => SetProperty(ref _blinkTotalTime, value);
		}

		[Ordinal(3)] 
		[RED("texturePart_Tracked")] 
		public CName TexturePart_Tracked
		{
			get => GetProperty(ref _texturePart_Tracked);
			set => SetProperty(ref _texturePart_Tracked, value);
		}

		[Ordinal(4)] 
		[RED("texturePart_Untracked")] 
		public CName TexturePart_Untracked
		{
			get => GetProperty(ref _texturePart_Untracked);
			set => SetProperty(ref _texturePart_Untracked, value);
		}

		[Ordinal(5)] 
		[RED("texturePart_Succeeded")] 
		public CName TexturePart_Succeeded
		{
			get => GetProperty(ref _texturePart_Succeeded);
			set => SetProperty(ref _texturePart_Succeeded, value);
		}

		[Ordinal(6)] 
		[RED("texturePart_Failed")] 
		public CName TexturePart_Failed
		{
			get => GetProperty(ref _texturePart_Failed);
			set => SetProperty(ref _texturePart_Failed, value);
		}

		[Ordinal(7)] 
		[RED("isLargeUpdateWidget")] 
		public CBool IsLargeUpdateWidget
		{
			get => GetProperty(ref _isLargeUpdateWidget);
			set => SetProperty(ref _isLargeUpdateWidget, value);
		}

		[Ordinal(8)] 
		[RED("entryName")] 
		public CWeakHandle<inkTextWidget> EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(9)] 
		[RED("entryOptional")] 
		public CWeakHandle<inkTextWidget> EntryOptional
		{
			get => GetProperty(ref _entryOptional);
			set => SetProperty(ref _entryOptional, value);
		}

		[Ordinal(10)] 
		[RED("stateIcon")] 
		public CWeakHandle<inkImageWidget> StateIcon
		{
			get => GetProperty(ref _stateIcon);
			set => SetProperty(ref _stateIcon, value);
		}

		[Ordinal(11)] 
		[RED("trackedIcon")] 
		public CWeakHandle<inkImageWidget> TrackedIcon
		{
			get => GetProperty(ref _trackedIcon);
			set => SetProperty(ref _trackedIcon, value);
		}

		[Ordinal(12)] 
		[RED("blinkWidget")] 
		public CWeakHandle<inkWidget> BlinkWidget
		{
			get => GetProperty(ref _blinkWidget);
			set => SetProperty(ref _blinkWidget, value);
		}

		[Ordinal(13)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(14)] 
		[RED("animBlinkDef")] 
		public CHandle<inkanimDefinition> AnimBlinkDef
		{
			get => GetProperty(ref _animBlinkDef);
			set => SetProperty(ref _animBlinkDef, value);
		}

		[Ordinal(15)] 
		[RED("animBlink")] 
		public CHandle<inkanimProxy> AnimBlink
		{
			get => GetProperty(ref _animBlink);
			set => SetProperty(ref _animBlink, value);
		}

		[Ordinal(16)] 
		[RED("animFadeDef")] 
		public CHandle<inkanimDefinition> AnimFadeDef
		{
			get => GetProperty(ref _animFadeDef);
			set => SetProperty(ref _animFadeDef, value);
		}

		[Ordinal(17)] 
		[RED("animFade")] 
		public CHandle<inkanimProxy> AnimFade
		{
			get => GetProperty(ref _animFade);
			set => SetProperty(ref _animFade, value);
		}

		[Ordinal(18)] 
		[RED("entryId")] 
		public CInt32 EntryId
		{
			get => GetProperty(ref _entryId);
			set => SetProperty(ref _entryId, value);
		}

		[Ordinal(19)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(21)] 
		[RED("parentEntry")] 
		public CWeakHandle<ObjectiveEntryLogicController> ParentEntry
		{
			get => GetProperty(ref _parentEntry);
			set => SetProperty(ref _parentEntry, value);
		}

		[Ordinal(22)] 
		[RED("childCount")] 
		public CInt32 ChildCount
		{
			get => GetProperty(ref _childCount);
			set => SetProperty(ref _childCount, value);
		}

		[Ordinal(23)] 
		[RED("updated")] 
		public CBool Updated
		{
			get => GetProperty(ref _updated);
			set => SetProperty(ref _updated, value);
		}

		[Ordinal(24)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetProperty(ref _isTracked);
			set => SetProperty(ref _isTracked, value);
		}

		[Ordinal(25)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get => GetProperty(ref _isOptional);
			set => SetProperty(ref _isOptional, value);
		}

		public ObjectiveEntryLogicController()
		{
			_blinkInterval = 0.800000F;
			_blinkTotalTime = 5.000000F;
			_texturePart_Tracked = "tracked_left";
			_texturePart_Untracked = "untracked_left";
			_texturePart_Succeeded = "succeeded";
			_texturePart_Failed = "failed";
		}
	}
}
