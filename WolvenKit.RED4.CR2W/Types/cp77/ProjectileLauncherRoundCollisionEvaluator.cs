using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRoundCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		private CEnum<gamedataProjectileOnCollisionAction> _collisionAction;
		private CBool _projectileStopped;
		private CInt32 _maxBounceCount;
		private CBool _projectileBounced;
		private CBool _projectileStopAndStick;
		private CBool _projectilePierced;

		[Ordinal(0)] 
		[RED("collisionAction")] 
		public CEnum<gamedataProjectileOnCollisionAction> CollisionAction
		{
			get => GetProperty(ref _collisionAction);
			set => SetProperty(ref _collisionAction, value);
		}

		[Ordinal(1)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetProperty(ref _projectileStopped);
			set => SetProperty(ref _projectileStopped, value);
		}

		[Ordinal(2)] 
		[RED("maxBounceCount")] 
		public CInt32 MaxBounceCount
		{
			get => GetProperty(ref _maxBounceCount);
			set => SetProperty(ref _maxBounceCount, value);
		}

		[Ordinal(3)] 
		[RED("projectileBounced")] 
		public CBool ProjectileBounced
		{
			get => GetProperty(ref _projectileBounced);
			set => SetProperty(ref _projectileBounced, value);
		}

		[Ordinal(4)] 
		[RED("projectileStopAndStick")] 
		public CBool ProjectileStopAndStick
		{
			get => GetProperty(ref _projectileStopAndStick);
			set => SetProperty(ref _projectileStopAndStick, value);
		}

		[Ordinal(5)] 
		[RED("projectilePierced")] 
		public CBool ProjectilePierced
		{
			get => GetProperty(ref _projectilePierced);
			set => SetProperty(ref _projectilePierced, value);
		}

		public ProjectileLauncherRoundCollisionEvaluator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
