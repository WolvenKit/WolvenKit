using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiContraPlayer : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _mass;
		private CFloat _jumpForce;
		private CFloat _movementSpeed;

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(2)] 
		[RED("jumpForce")] 
		public CFloat JumpForce
		{
			get => GetProperty(ref _jumpForce);
			set => SetProperty(ref _jumpForce, value);
		}

		[Ordinal(3)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetProperty(ref _movementSpeed);
			set => SetProperty(ref _movementSpeed, value);
		}
	}
}
