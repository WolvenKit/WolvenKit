using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsTimedParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsTimedAction>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsTimedAction>>(value);
		}

		[Ordinal(1)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		public scnChoiceNodeNsTimedParams()
		{
			Duration = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
