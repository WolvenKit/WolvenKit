using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpiderbotHeavyProjectile : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CFloat _startVelocity;
		private CFloat _lifetime;
		private CBool _alive;
		private CBool _hit;

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
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
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
		public CFloat Lifetime_492
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

		[Ordinal(56)] 
		[RED("hit")] 
		public CBool Hit
		{
			get
			{
				if (_hit == null)
				{
					_hit = (CBool) CR2WTypeManager.Create("Bool", "hit", cr2w, this);
				}
				return _hit;
			}
			set
			{
				if (_hit == value)
				{
					return;
				}
				_hit = value;
				PropertySet(this);
			}
		}

		public SpiderbotHeavyProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
