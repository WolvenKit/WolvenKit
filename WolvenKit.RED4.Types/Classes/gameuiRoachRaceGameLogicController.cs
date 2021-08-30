using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		private CFloat _jumpAcceleration;
		private CFloat _jumpCancelAcceleration;
		private CFloat _gravity;
		private Vector2 _playerSpawnPoint;
		private CFloat _pixelsPerScore;
		private CFloat _invincibilityTime;
		private CFloat _maxSpeedMultiplier;
		private CFloat _multiplierPerScore;
		private inkWidgetReference _house;
		private inkWidgetReference _ground;
		private CName _startAnimation;
		private CName _deathAnimation;
		private CArray<gameuiRoachRaceChunkLayer> _layers;
		private CName _damageAnimation;
		private CName _healAnimation;
		private inkTextWidgetReference _healthText;
		private inkTextWidgetReference _scoreText;
		private inkTextWidgetReference _scoreMultiplierText;
		private CInt32 _previousHealth;

		[Ordinal(10)] 
		[RED("jumpAcceleration")] 
		public CFloat JumpAcceleration
		{
			get => GetProperty(ref _jumpAcceleration);
			set => SetProperty(ref _jumpAcceleration, value);
		}

		[Ordinal(11)] 
		[RED("jumpCancelAcceleration")] 
		public CFloat JumpCancelAcceleration
		{
			get => GetProperty(ref _jumpCancelAcceleration);
			set => SetProperty(ref _jumpCancelAcceleration, value);
		}

		[Ordinal(12)] 
		[RED("gravity")] 
		public CFloat Gravity
		{
			get => GetProperty(ref _gravity);
			set => SetProperty(ref _gravity, value);
		}

		[Ordinal(13)] 
		[RED("playerSpawnPoint")] 
		public Vector2 PlayerSpawnPoint
		{
			get => GetProperty(ref _playerSpawnPoint);
			set => SetProperty(ref _playerSpawnPoint, value);
		}

		[Ordinal(14)] 
		[RED("pixelsPerScore")] 
		public CFloat PixelsPerScore
		{
			get => GetProperty(ref _pixelsPerScore);
			set => SetProperty(ref _pixelsPerScore, value);
		}

		[Ordinal(15)] 
		[RED("invincibilityTime")] 
		public CFloat InvincibilityTime
		{
			get => GetProperty(ref _invincibilityTime);
			set => SetProperty(ref _invincibilityTime, value);
		}

		[Ordinal(16)] 
		[RED("maxSpeedMultiplier")] 
		public CFloat MaxSpeedMultiplier
		{
			get => GetProperty(ref _maxSpeedMultiplier);
			set => SetProperty(ref _maxSpeedMultiplier, value);
		}

		[Ordinal(17)] 
		[RED("multiplierPerScore")] 
		public CFloat MultiplierPerScore
		{
			get => GetProperty(ref _multiplierPerScore);
			set => SetProperty(ref _multiplierPerScore, value);
		}

		[Ordinal(18)] 
		[RED("house")] 
		public inkWidgetReference House
		{
			get => GetProperty(ref _house);
			set => SetProperty(ref _house, value);
		}

		[Ordinal(19)] 
		[RED("ground")] 
		public inkWidgetReference Ground
		{
			get => GetProperty(ref _ground);
			set => SetProperty(ref _ground, value);
		}

		[Ordinal(20)] 
		[RED("startAnimation")] 
		public CName StartAnimation
		{
			get => GetProperty(ref _startAnimation);
			set => SetProperty(ref _startAnimation, value);
		}

		[Ordinal(21)] 
		[RED("deathAnimation")] 
		public CName DeathAnimation
		{
			get => GetProperty(ref _deathAnimation);
			set => SetProperty(ref _deathAnimation, value);
		}

		[Ordinal(22)] 
		[RED("layers")] 
		public CArray<gameuiRoachRaceChunkLayer> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		[Ordinal(23)] 
		[RED("damageAnimation")] 
		public CName DamageAnimation
		{
			get => GetProperty(ref _damageAnimation);
			set => SetProperty(ref _damageAnimation, value);
		}

		[Ordinal(24)] 
		[RED("healAnimation")] 
		public CName HealAnimation
		{
			get => GetProperty(ref _healAnimation);
			set => SetProperty(ref _healAnimation, value);
		}

		[Ordinal(25)] 
		[RED("healthText")] 
		public inkTextWidgetReference HealthText
		{
			get => GetProperty(ref _healthText);
			set => SetProperty(ref _healthText, value);
		}

		[Ordinal(26)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get => GetProperty(ref _scoreText);
			set => SetProperty(ref _scoreText, value);
		}

		[Ordinal(27)] 
		[RED("scoreMultiplierText")] 
		public inkTextWidgetReference ScoreMultiplierText
		{
			get => GetProperty(ref _scoreMultiplierText);
			set => SetProperty(ref _scoreMultiplierText, value);
		}

		[Ordinal(28)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		public gameuiRoachRaceGameLogicController()
		{
			_maxSpeedMultiplier = 2.000000F;
			_multiplierPerScore = 0.020000F;
		}
	}
}
