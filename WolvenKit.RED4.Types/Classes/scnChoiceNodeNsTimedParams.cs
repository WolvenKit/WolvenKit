using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChoiceNodeNsTimedParams : ISerializable
	{
		private CEnum<scnChoiceNodeNsTimedAction> _action;
		private CBool _timeLimitedFinish;
		private scnSceneTime _duration;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get => GetProperty(ref _timeLimitedFinish);
			set => SetProperty(ref _timeLimitedFinish, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
