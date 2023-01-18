using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetMoveState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("isJumping")] 
		public CBool IsJumping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isFalling")] 
		public CBool IsFalling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isDoubleJumped")] 
		public CBool IsDoubleJumped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("moveStyle")] 
		public CEnum<gameMuppetMoveStyle> MoveStyle
		{
			get => GetPropertyValue<CEnum<gameMuppetMoveStyle>>();
			set => SetPropertyValue<CEnum<gameMuppetMoveStyle>>(value);
		}

		[Ordinal(5)] 
		[RED("jumpStartFrameId")] 
		public CUInt32 JumpStartFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("landFrameId")] 
		public CUInt32 LandFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMuppetMoveState()
		{
			JumpStartFrameId = 4294967295;
			LandFrameId = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
