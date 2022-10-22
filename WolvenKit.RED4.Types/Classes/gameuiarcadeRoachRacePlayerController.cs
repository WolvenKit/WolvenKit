using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRacePlayerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("collider")] 
		public gameuiarcadeBoundingRect Collider
		{
			get => GetPropertyValue<gameuiarcadeBoundingRect>();
			set => SetPropertyValue<gameuiarcadeBoundingRect>(value);
		}

		[Ordinal(2)] 
		[RED("singleJumpBoost")] 
		public Vector2 SingleJumpBoost
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("doubleJumpBoost")] 
		public Vector2 DoubleJumpBoost
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("gravity")] 
		public Vector2 Gravity
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("teleportLockoutTime")] 
		public CFloat TeleportLockoutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("carrotPowerupVelocityBoostModifier")] 
		public CFloat CarrotPowerupVelocityBoostModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("runningBoundingRectangleRelativeSize")] 
		public Vector2 RunningBoundingRectangleRelativeSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(8)] 
		[RED("jumpingboundingRectangleRelativeSize")] 
		public Vector2 JumpingboundingRectangleRelativeSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(9)] 
		[RED("poweredupboundingRectangleRelativeSize")] 
		public Vector2 PoweredupboundingRectangleRelativeSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(10)] 
		[RED("invincibilityTime")] 
		public CFloat InvincibilityTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("invincibilityWarningTime")] 
		public CFloat InvincibilityWarningTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("roachDeathAnimationTime")] 
		public CFloat RoachDeathAnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("roachDeathAnimationDisplacement")] 
		public CFloat RoachDeathAnimationDisplacement
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("jumpSFX")] 
		public CName JumpSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("doubleJumpSFX")] 
		public CName DoubleJumpSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("teleportSFX")] 
		public CName TeleportSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("invincibilityStartSFX")] 
		public CName InvincibilityStartSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("invincibilityStopSFX")] 
		public CName InvincibilityStopSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("carrotPowerupStartSFX")] 
		public CName CarrotPowerupStartSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("carrotPowerupStopSFX")] 
		public CName CarrotPowerupStopSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiarcadeRoachRacePlayerController()
		{
			Collider = new();
			SingleJumpBoost = new();
			DoubleJumpBoost = new();
			Gravity = new();
			TeleportLockoutTime = 0.500000F;
			CarrotPowerupVelocityBoostModifier = 0.200000F;
			RunningBoundingRectangleRelativeSize = new() { X = 1.000000F, Y = 1.000000F };
			JumpingboundingRectangleRelativeSize = new() { X = 1.000000F, Y = 1.000000F };
			PoweredupboundingRectangleRelativeSize = new() { X = 1.000000F, Y = 1.000000F };
			InvincibilityTime = 3.000000F;
			InvincibilityWarningTime = 0.500000F;
			Image = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
