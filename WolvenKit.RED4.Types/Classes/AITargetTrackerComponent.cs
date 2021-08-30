using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITargetTrackerComponent : gameComponent
	{
		private CBool _triggersCombat;

		[Ordinal(4)] 
		[RED("TriggersCombat")] 
		public CBool TriggersCombat
		{
			get => GetProperty(ref _triggersCombat);
			set => SetProperty(ref _triggersCombat, value);
		}

		public AITargetTrackerComponent()
		{
			_triggersCombat = true;
		}
	}
}
