using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProjectileLauncherRoundCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)] 
		[RED("collisionAction")] 
		public CEnum<gamedataProjectileOnCollisionAction> CollisionAction
		{
			get => GetPropertyValue<CEnum<gamedataProjectileOnCollisionAction>>();
			set => SetPropertyValue<CEnum<gamedataProjectileOnCollisionAction>>(value);
		}

		[Ordinal(1)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("maxBounceCount")] 
		public CInt32 MaxBounceCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("projectileBounced")] 
		public CBool ProjectileBounced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("projectileStopAndStick")] 
		public CBool ProjectileStopAndStick
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("projectilePierced")] 
		public CBool ProjectilePierced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProjectileLauncherRoundCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
