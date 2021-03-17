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
			get => GetProperty(ref _pointOfViewTransform);
			set => SetProperty(ref _pointOfViewTransform, value);
		}

		[Ordinal(1)] 
		[RED("projectileHitplaneSpread")] 
		public Vector4 ProjectileHitplaneSpread
		{
			get => GetProperty(ref _projectileHitplaneSpread);
			set => SetProperty(ref _projectileHitplaneSpread, value);
		}

		[Ordinal(2)] 
		[RED("bulletStartPosition")] 
		public Vector4 BulletStartPosition
		{
			get => GetProperty(ref _bulletStartPosition);
			set => SetProperty(ref _bulletStartPosition, value);
		}

		public gameAttackDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
