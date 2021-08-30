using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		private CEnum<questProximityProgressBarAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questProximityProgressBarAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public questProximityProgressBar_ConditionType()
		{
			_action = new() { Value = Enums.questProximityProgressBarAction.Completed };
		}
	}
}
