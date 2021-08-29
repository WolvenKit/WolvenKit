using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private CBool _event;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetProperty(ref _grenadeThrown);
			set => SetProperty(ref _grenadeThrown, value);
		}

		[Ordinal(1)] 
		[RED("event")] 
		public CBool Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}
	}
}
