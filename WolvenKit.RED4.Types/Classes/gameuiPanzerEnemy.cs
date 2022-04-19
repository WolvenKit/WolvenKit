using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerEnemy : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] 
		[RED("noBonusChanceCoeff")] 
		public CUInt32 NoBonusChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CInt32 Health
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("score")] 
		public CUInt32 Score
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("shootPoint")] 
		public Vector2 ShootPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("bulletSpeed")] 
		public CFloat BulletSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("explosionLibraryName")] 
		public CName ExplosionLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("bulletLibraryName")] 
		public CName BulletLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("lifeBonusLibraryName")] 
		public CName LifeBonusLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("lifeBonusChanceCoeff")] 
		public CUInt32 LifeBonusChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("scoreBonusLibraryName")] 
		public CName ScoreBonusLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("scoreBonusChanceCoeff")] 
		public CUInt32 ScoreBonusChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("score50ChanceCoeff")] 
		public CUInt32 Score50ChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("score100ChanceCoeff")] 
		public CUInt32 Score100ChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("score200ChanceCoeff")] 
		public CUInt32 Score200ChanceCoeff
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiPanzerEnemy()
		{
			NoBonusChanceCoeff = 80;
			ShootPoint = new();
			LifeBonusChanceCoeff = 5;
			ScoreBonusChanceCoeff = 15;
			Score50ChanceCoeff = 50;
			Score100ChanceCoeff = 35;
			Score200ChanceCoeff = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
