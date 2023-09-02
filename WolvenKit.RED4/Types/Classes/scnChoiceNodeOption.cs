using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeOption : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("screenplayOptionId")] 
		public scnscreenplayItemId ScreenplayOptionId
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(1)] 
		[RED("blueline")] 
		public CBool Blueline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isSingleChoice")] 
		public CBool IsSingleChoice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		[Ordinal(4)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get => GetPropertyValue<CHandle<scnChoiceNodeNsTimedParams>>();
			set => SetPropertyValue<CHandle<scnChoiceNodeNsTimedParams>>(value);
		}

		[Ordinal(5)] 
		[RED("questCondition")] 
		public CHandle<questIBaseCondition> QuestCondition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(6)] 
		[RED("triggerCondition")] 
		public CHandle<questIBaseCondition> TriggerCondition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(7)] 
		[RED("bluelineCondition")] 
		public CHandle<questIBaseCondition> BluelineCondition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(8)] 
		[RED("gameplayAction")] 
		public TweakDBID GameplayAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("iconTagIds")] 
		public CArray<TweakDBID> IconTagIds
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(10)] 
		[RED("exDataFlags")] 
		public CUInt32 ExDataFlags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("mappinReferencePointId")] 
		public scnReferencePointId MappinReferencePointId
		{
			get => GetPropertyValue<scnReferencePointId>();
			set => SetPropertyValue<scnReferencePointId>(value);
		}

		[Ordinal(12)] 
		[RED("timedCondition")] 
		public CHandle<scnTimedCondition> TimedCondition
		{
			get => GetPropertyValue<CHandle<scnTimedCondition>>();
			set => SetPropertyValue<CHandle<scnTimedCondition>>(value);
		}

		public scnChoiceNodeOption()
		{
			ScreenplayOptionId = new scnscreenplayItemId { Id = 4294967040 };
			Type = new gameinteractionsChoiceTypeWrapper();
			IconTagIds = new();
			MappinReferencePointId = new scnReferencePointId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
