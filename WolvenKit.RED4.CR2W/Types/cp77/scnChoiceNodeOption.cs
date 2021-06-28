using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeOption : CVariable
	{
		private scnscreenplayItemId _screenplayOptionId;
		private CBool _blueline;
		private CBool _isSingleChoice;
		private gameinteractionsChoiceTypeWrapper _type;
		private CHandle<scnChoiceNodeNsTimedParams> _timedParams;
		private CHandle<questIBaseCondition> _questCondition;
		private CHandle<questIBaseCondition> _triggerCondition;
		private CHandle<questIBaseCondition> _bluelineCondition;
		private TweakDBID _gameplayAction;
		private CArray<TweakDBID> _iconTagIds;
		private CUInt32 _exDataFlags;
		private scnReferencePointId _mappinReferencePointId;
		private CHandle<scnTimedCondition> _timedCondition;

		[Ordinal(0)] 
		[RED("screenplayOptionId")] 
		public scnscreenplayItemId ScreenplayOptionId
		{
			get => GetProperty(ref _screenplayOptionId);
			set => SetProperty(ref _screenplayOptionId, value);
		}

		[Ordinal(1)] 
		[RED("blueline")] 
		public CBool Blueline
		{
			get => GetProperty(ref _blueline);
			set => SetProperty(ref _blueline, value);
		}

		[Ordinal(2)] 
		[RED("isSingleChoice")] 
		public CBool IsSingleChoice
		{
			get => GetProperty(ref _isSingleChoice);
			set => SetProperty(ref _isSingleChoice, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get => GetProperty(ref _timedParams);
			set => SetProperty(ref _timedParams, value);
		}

		[Ordinal(5)] 
		[RED("questCondition")] 
		public CHandle<questIBaseCondition> QuestCondition
		{
			get => GetProperty(ref _questCondition);
			set => SetProperty(ref _questCondition, value);
		}

		[Ordinal(6)] 
		[RED("triggerCondition")] 
		public CHandle<questIBaseCondition> TriggerCondition
		{
			get => GetProperty(ref _triggerCondition);
			set => SetProperty(ref _triggerCondition, value);
		}

		[Ordinal(7)] 
		[RED("bluelineCondition")] 
		public CHandle<questIBaseCondition> BluelineCondition
		{
			get => GetProperty(ref _bluelineCondition);
			set => SetProperty(ref _bluelineCondition, value);
		}

		[Ordinal(8)] 
		[RED("gameplayAction")] 
		public TweakDBID GameplayAction
		{
			get => GetProperty(ref _gameplayAction);
			set => SetProperty(ref _gameplayAction, value);
		}

		[Ordinal(9)] 
		[RED("iconTagIds")] 
		public CArray<TweakDBID> IconTagIds
		{
			get => GetProperty(ref _iconTagIds);
			set => SetProperty(ref _iconTagIds, value);
		}

		[Ordinal(10)] 
		[RED("exDataFlags")] 
		public CUInt32 ExDataFlags
		{
			get => GetProperty(ref _exDataFlags);
			set => SetProperty(ref _exDataFlags, value);
		}

		[Ordinal(11)] 
		[RED("mappinReferencePointId")] 
		public scnReferencePointId MappinReferencePointId
		{
			get => GetProperty(ref _mappinReferencePointId);
			set => SetProperty(ref _mappinReferencePointId, value);
		}

		[Ordinal(12)] 
		[RED("timedCondition")] 
		public CHandle<scnTimedCondition> TimedCondition
		{
			get => GetProperty(ref _timedCondition);
			set => SetProperty(ref _timedCondition, value);
		}

		public scnChoiceNodeOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
