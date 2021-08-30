using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAnimMoveOnSplineParams : RedBaseClass
	{
		private CName _controllersSetupName;
		private CFloat _blendTime;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CBool _turnCharacterToMatchVelocity;
		private CName _customStartAnimationName;
		private CName _customMainAnimationName;
		private CName _customStopAnimationName;
		private CBool _startSnapToTerrain;
		private CBool _mainSnapToTerrain;
		private CBool _stopSnapToTerrain;
		private CFloat _startSnapToTerrainBlendTime;
		private CFloat _stopSnapToTerrainBlendTime;

		[Ordinal(0)] 
		[RED("controllersSetupName")] 
		public CName ControllersSetupName
		{
			get => GetProperty(ref _controllersSetupName);
			set => SetProperty(ref _controllersSetupName, value);
		}

		[Ordinal(1)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(2)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(3)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(4)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(5)] 
		[RED("customStartAnimationName")] 
		public CName CustomStartAnimationName
		{
			get => GetProperty(ref _customStartAnimationName);
			set => SetProperty(ref _customStartAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("customMainAnimationName")] 
		public CName CustomMainAnimationName
		{
			get => GetProperty(ref _customMainAnimationName);
			set => SetProperty(ref _customMainAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("customStopAnimationName")] 
		public CName CustomStopAnimationName
		{
			get => GetProperty(ref _customStopAnimationName);
			set => SetProperty(ref _customStopAnimationName, value);
		}

		[Ordinal(8)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get => GetProperty(ref _startSnapToTerrain);
			set => SetProperty(ref _startSnapToTerrain, value);
		}

		[Ordinal(9)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get => GetProperty(ref _mainSnapToTerrain);
			set => SetProperty(ref _mainSnapToTerrain, value);
		}

		[Ordinal(10)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get => GetProperty(ref _stopSnapToTerrain);
			set => SetProperty(ref _stopSnapToTerrain, value);
		}

		[Ordinal(11)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get => GetProperty(ref _startSnapToTerrainBlendTime);
			set => SetProperty(ref _startSnapToTerrainBlendTime, value);
		}

		[Ordinal(12)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get => GetProperty(ref _stopSnapToTerrainBlendTime);
			set => SetProperty(ref _stopSnapToTerrainBlendTime, value);
		}

		public questAnimMoveOnSplineParams()
		{
			_controllersSetupName = "Walk";
		}
	}
}
