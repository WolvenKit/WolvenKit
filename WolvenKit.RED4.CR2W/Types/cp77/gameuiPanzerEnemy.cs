using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemy : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CUInt32 _noBonusChanceCoeff;
		private CInt32 _health;
		private CUInt32 _score;
		private Vector2 _shootPoint;
		private CFloat _bulletSpeed;
		private CName _gameLayerName;
		private CName _explosionLibraryName;
		private CName _bulletLibraryName;
		private CName _lifeBonusLibraryName;
		private CUInt32 _lifeBonusChanceCoeff;
		private CName _scoreBonusLibraryName;
		private CUInt32 _scoreBonusChanceCoeff;
		private CUInt32 _score50ChanceCoeff;
		private CUInt32 _score100ChanceCoeff;
		private CUInt32 _score200ChanceCoeff;

		[Ordinal(1)] 
		[RED("noBonusChanceCoeff")] 
		public CUInt32 NoBonusChanceCoeff
		{
			get => GetProperty(ref _noBonusChanceCoeff);
			set => SetProperty(ref _noBonusChanceCoeff, value);
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CInt32 Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(3)] 
		[RED("score")] 
		public CUInt32 Score
		{
			get => GetProperty(ref _score);
			set => SetProperty(ref _score, value);
		}

		[Ordinal(4)] 
		[RED("shootPoint")] 
		public Vector2 ShootPoint
		{
			get => GetProperty(ref _shootPoint);
			set => SetProperty(ref _shootPoint, value);
		}

		[Ordinal(5)] 
		[RED("bulletSpeed")] 
		public CFloat BulletSpeed
		{
			get => GetProperty(ref _bulletSpeed);
			set => SetProperty(ref _bulletSpeed, value);
		}

		[Ordinal(6)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get => GetProperty(ref _gameLayerName);
			set => SetProperty(ref _gameLayerName, value);
		}

		[Ordinal(7)] 
		[RED("explosionLibraryName")] 
		public CName ExplosionLibraryName
		{
			get => GetProperty(ref _explosionLibraryName);
			set => SetProperty(ref _explosionLibraryName, value);
		}

		[Ordinal(8)] 
		[RED("bulletLibraryName")] 
		public CName BulletLibraryName
		{
			get => GetProperty(ref _bulletLibraryName);
			set => SetProperty(ref _bulletLibraryName, value);
		}

		[Ordinal(9)] 
		[RED("lifeBonusLibraryName")] 
		public CName LifeBonusLibraryName
		{
			get => GetProperty(ref _lifeBonusLibraryName);
			set => SetProperty(ref _lifeBonusLibraryName, value);
		}

		[Ordinal(10)] 
		[RED("lifeBonusChanceCoeff")] 
		public CUInt32 LifeBonusChanceCoeff
		{
			get => GetProperty(ref _lifeBonusChanceCoeff);
			set => SetProperty(ref _lifeBonusChanceCoeff, value);
		}

		[Ordinal(11)] 
		[RED("scoreBonusLibraryName")] 
		public CName ScoreBonusLibraryName
		{
			get => GetProperty(ref _scoreBonusLibraryName);
			set => SetProperty(ref _scoreBonusLibraryName, value);
		}

		[Ordinal(12)] 
		[RED("scoreBonusChanceCoeff")] 
		public CUInt32 ScoreBonusChanceCoeff
		{
			get => GetProperty(ref _scoreBonusChanceCoeff);
			set => SetProperty(ref _scoreBonusChanceCoeff, value);
		}

		[Ordinal(13)] 
		[RED("score50ChanceCoeff")] 
		public CUInt32 Score50ChanceCoeff
		{
			get => GetProperty(ref _score50ChanceCoeff);
			set => SetProperty(ref _score50ChanceCoeff, value);
		}

		[Ordinal(14)] 
		[RED("score100ChanceCoeff")] 
		public CUInt32 Score100ChanceCoeff
		{
			get => GetProperty(ref _score100ChanceCoeff);
			set => SetProperty(ref _score100ChanceCoeff, value);
		}

		[Ordinal(15)] 
		[RED("score200ChanceCoeff")] 
		public CUInt32 Score200ChanceCoeff
		{
			get => GetProperty(ref _score200ChanceCoeff);
			set => SetProperty(ref _score200ChanceCoeff, value);
		}

		public gameuiPanzerEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
