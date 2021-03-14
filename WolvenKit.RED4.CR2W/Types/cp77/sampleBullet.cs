using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleBullet : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime;
		private CHandle<BulletCollisionEvaluator> _bulletCollisionEvaluator;
		private CBool _alive;

		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get
			{
				if (_meshComponent == null)
				{
					_meshComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "meshComponent", cr2w, this);
				}
				return _meshComponent;
			}
			set
			{
				if (_meshComponent == value)
				{
					return;
				}
				_meshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get
			{
				if (_countTime == null)
				{
					_countTime = (CFloat) CR2WTypeManager.Create("Float", "countTime", cr2w, this);
				}
				return _countTime;
			}
			set
			{
				if (_countTime == value)
				{
					return;
				}
				_countTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get
			{
				if (_startVelocity == null)
				{
					_startVelocity = (CFloat) CR2WTypeManager.Create("Float", "startVelocity", cr2w, this);
				}
				return _startVelocity;
			}
			set
			{
				if (_startVelocity == value)
				{
					return;
				}
				_startVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("lifetime")] 
		public CFloat Lifetime_456
		{
			get
			{
				if (_lifetime == null)
				{
					_lifetime = (CFloat) CR2WTypeManager.Create("Float", "lifetime", cr2w, this);
				}
				return _lifetime;
			}
			set
			{
				if (_lifetime == value)
				{
					return;
				}
				_lifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get
			{
				if (_bulletCollisionEvaluator == null)
				{
					_bulletCollisionEvaluator = (CHandle<BulletCollisionEvaluator>) CR2WTypeManager.Create("handle:BulletCollisionEvaluator", "BulletCollisionEvaluator", cr2w, this);
				}
				return _bulletCollisionEvaluator;
			}
			set
			{
				if (_bulletCollisionEvaluator == value)
				{
					return;
				}
				_bulletCollisionEvaluator = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		public sampleBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
