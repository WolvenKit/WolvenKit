using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioBreathingStateTransitionMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fromNames")] 
		public CArray<CName> FromNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("toName")] 
		public CName ToName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("transitionStateName")] 
		public CName TransitionStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("conditionType")] 
		public CEnum<audioBreathingTransitionType> ConditionType
		{
			get => GetPropertyValue<CEnum<audioBreathingTransitionType>>();
			set => SetPropertyValue<CEnum<audioBreathingTransitionType>>(value);
		}

		[Ordinal(5)] 
		[RED("conditionComparator")] 
		public CEnum<audioBreathingTransitionComparator> ConditionComparator
		{
			get => GetPropertyValue<CEnum<audioBreathingTransitionComparator>>();
			set => SetPropertyValue<CEnum<audioBreathingTransitionComparator>>(value);
		}

		[Ordinal(6)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("eventTags")] 
		public CArray<CEnum<audiobreathingEventTag>> EventTags
		{
			get => GetPropertyValue<CArray<CEnum<audiobreathingEventTag>>>();
			set => SetPropertyValue<CArray<CEnum<audiobreathingEventTag>>>(value);
		}

		[Ordinal(8)] 
		[RED("isImmediate")] 
		public CBool IsImmediate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioBreathingStateTransitionMetadata()
		{
			FromNames = new();
			EventTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
