using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetMoveState : RedBaseClass
	{
		private CFloat _desiredSpeed;
		private CBool _isJumping;
		private CBool _isFalling;
		private CBool _isDoubleJumped;
		private CEnum<gameMuppetMoveStyle> _moveStyle;
		private CUInt32 _jumpStartFrameId;
		private CUInt32 _landFrameId;

		[Ordinal(0)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get => GetProperty(ref _desiredSpeed);
			set => SetProperty(ref _desiredSpeed, value);
		}

		[Ordinal(1)] 
		[RED("isJumping")] 
		public CBool IsJumping
		{
			get => GetProperty(ref _isJumping);
			set => SetProperty(ref _isJumping, value);
		}

		[Ordinal(2)] 
		[RED("isFalling")] 
		public CBool IsFalling
		{
			get => GetProperty(ref _isFalling);
			set => SetProperty(ref _isFalling, value);
		}

		[Ordinal(3)] 
		[RED("isDoubleJumped")] 
		public CBool IsDoubleJumped
		{
			get => GetProperty(ref _isDoubleJumped);
			set => SetProperty(ref _isDoubleJumped, value);
		}

		[Ordinal(4)] 
		[RED("moveStyle")] 
		public CEnum<gameMuppetMoveStyle> MoveStyle
		{
			get => GetProperty(ref _moveStyle);
			set => SetProperty(ref _moveStyle, value);
		}

		[Ordinal(5)] 
		[RED("jumpStartFrameId")] 
		public CUInt32 JumpStartFrameId
		{
			get => GetProperty(ref _jumpStartFrameId);
			set => SetProperty(ref _jumpStartFrameId, value);
		}

		[Ordinal(6)] 
		[RED("landFrameId")] 
		public CUInt32 LandFrameId
		{
			get => GetProperty(ref _landFrameId);
			set => SetProperty(ref _landFrameId, value);
		}

		public gameMuppetMoveState()
		{
			_jumpStartFrameId = 4294967295;
			_landFrameId = 4294967295;
		}
	}
}
