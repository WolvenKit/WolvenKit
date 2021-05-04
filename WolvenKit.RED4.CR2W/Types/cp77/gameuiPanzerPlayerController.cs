using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerPlayerController : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _bulletSpeed;
		private Vector2 _bulletSpawnOffset;
		private CName _bulletLibraryname;
		private CFloat _shootInterval;
		private CName _gameLayerName;
		private CName _invulnerableAnimationName;
		private CName _explosionLibraryName;

		[Ordinal(1)] 
		[RED("bulletSpeed")] 
		public CFloat BulletSpeed
		{
			get => GetProperty(ref _bulletSpeed);
			set => SetProperty(ref _bulletSpeed, value);
		}

		[Ordinal(2)] 
		[RED("bulletSpawnOffset")] 
		public Vector2 BulletSpawnOffset
		{
			get => GetProperty(ref _bulletSpawnOffset);
			set => SetProperty(ref _bulletSpawnOffset, value);
		}

		[Ordinal(3)] 
		[RED("bulletLibraryname")] 
		public CName BulletLibraryname
		{
			get => GetProperty(ref _bulletLibraryname);
			set => SetProperty(ref _bulletLibraryname, value);
		}

		[Ordinal(4)] 
		[RED("shootInterval")] 
		public CFloat ShootInterval
		{
			get => GetProperty(ref _shootInterval);
			set => SetProperty(ref _shootInterval, value);
		}

		[Ordinal(5)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get => GetProperty(ref _gameLayerName);
			set => SetProperty(ref _gameLayerName, value);
		}

		[Ordinal(6)] 
		[RED("invulnerableAnimationName")] 
		public CName InvulnerableAnimationName
		{
			get => GetProperty(ref _invulnerableAnimationName);
			set => SetProperty(ref _invulnerableAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("explosionLibraryName")] 
		public CName ExplosionLibraryName
		{
			get => GetProperty(ref _explosionLibraryName);
			set => SetProperty(ref _explosionLibraryName, value);
		}

		public gameuiPanzerPlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
