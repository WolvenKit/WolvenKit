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
			get
			{
				if (_collisionAction == null)
				{
					_collisionAction = (CEnum<gamedataProjectileOnCollisionAction>) CR2WTypeManager.Create("gamedataProjectileOnCollisionAction", "collisionAction", cr2w, this);
				}
				return _collisionAction;
			}
			set
			{
				if (_collisionAction == value)
				{
					return;
				}
				_collisionAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get
			{
				if (_projectileStopped == null)
				{
					_projectileStopped = (CBool) CR2WTypeManager.Create("Bool", "projectileStopped", cr2w, this);
				}
				return _projectileStopped;
			}
			set
			{
				if (_projectileStopped == value)
				{
					return;
				}
				_projectileStopped = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxBounceCount")] 
		public CInt32 MaxBounceCount
		{
			get
			{
				if (_maxBounceCount == null)
				{
					_maxBounceCount = (CInt32) CR2WTypeManager.Create("Int32", "maxBounceCount", cr2w, this);
				}
				return _maxBounceCount;
			}
			set
			{
				if (_maxBounceCount == value)
				{
					return;
				}
				_maxBounceCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("projectileBounced")] 
		public CBool ProjectileBounced
		{
			get
			{
				if (_projectileBounced == null)
				{
					_projectileBounced = (CBool) CR2WTypeManager.Create("Bool", "projectileBounced", cr2w, this);
				}
				return _projectileBounced;
			}
			set
			{
				if (_projectileBounced == value)
				{
					return;
				}
				_projectileBounced = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("projectileStopAndStick")] 
		public CBool ProjectileStopAndStick
		{
			get
			{
				if (_projectileStopAndStick == null)
				{
					_projectileStopAndStick = (CBool) CR2WTypeManager.Create("Bool", "projectileStopAndStick", cr2w, this);
				}
				return _projectileStopAndStick;
			}
			set
			{
				if (_projectileStopAndStick == value)
				{
					return;
				}
				_projectileStopAndStick = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("projectilePierced")] 
		public CBool ProjectilePierced
		{
			get
			{
				if (_projectilePierced == null)
				{
					_projectilePierced = (CBool) CR2WTypeManager.Create("Bool", "projectilePierced", cr2w, this);
				}
				return _projectilePierced;
			}
			set
			{
				if (_projectilePierced == value)
				{
					return;
				}
				_projectilePierced = value;
				PropertySet(this);
			}
		}

		public ProjectileLauncherRoundCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
