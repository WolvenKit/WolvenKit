using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetChargedThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private Vector4 _localAimForward;
		private Vector4 _localAimPosition;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetProperty(ref _grenadeThrown);
			set => SetProperty(ref _grenadeThrown, value);
		}

		[Ordinal(1)] 
		[RED("localAimForward")] 
		public Vector4 LocalAimForward
		{
			get => GetProperty(ref _localAimForward);
			set => SetProperty(ref _localAimForward, value);
		}

		[Ordinal(2)] 
		[RED("localAimPosition")] 
		public Vector4 LocalAimPosition
		{
			get => GetProperty(ref _localAimPosition);
			set => SetProperty(ref _localAimPosition, value);
		}
	}
}
