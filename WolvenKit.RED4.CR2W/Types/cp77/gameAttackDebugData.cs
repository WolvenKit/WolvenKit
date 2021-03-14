using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttackDebugData : CVariable
	{
		private WorldTransform _pointOfViewTransform;
		private Vector4 _projectileHitplaneSpread;
		private Vector4 _bulletStartPosition;

		[Ordinal(0)] 
		[RED("pointOfViewTransform")] 
		public WorldTransform PointOfViewTransform
		{
			get
			{
				if (_pointOfViewTransform == null)
				{
					_pointOfViewTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "pointOfViewTransform", cr2w, this);
				}
				return _pointOfViewTransform;
			}
			set
			{
				if (_pointOfViewTransform == value)
				{
					return;
				}
				_pointOfViewTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("projectileHitplaneSpread")] 
		public Vector4 ProjectileHitplaneSpread
		{
			get
			{
				if (_projectileHitplaneSpread == null)
				{
					_projectileHitplaneSpread = (Vector4) CR2WTypeManager.Create("Vector4", "projectileHitplaneSpread", cr2w, this);
				}
				return _projectileHitplaneSpread;
			}
			set
			{
				if (_projectileHitplaneSpread == value)
				{
					return;
				}
				_projectileHitplaneSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bulletStartPosition")] 
		public Vector4 BulletStartPosition
		{
			get
			{
				if (_bulletStartPosition == null)
				{
					_bulletStartPosition = (Vector4) CR2WTypeManager.Create("Vector4", "bulletStartPosition", cr2w, this);
				}
				return _bulletStartPosition;
			}
			set
			{
				if (_bulletStartPosition == value)
				{
					return;
				}
				_bulletStartPosition = value;
				PropertySet(this);
			}
		}

		public gameAttackDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
