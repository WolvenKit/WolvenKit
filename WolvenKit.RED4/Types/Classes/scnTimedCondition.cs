using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnTimedCondition : ISerializable
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsTimedAction>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsTimedAction>>(value);
		}

		[Ordinal(2)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnTimedCondition()
		{
			Duration = new scnSceneTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
