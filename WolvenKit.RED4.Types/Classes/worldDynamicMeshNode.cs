using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDynamicMeshNode : worldMeshNode
	{
		private CBool _startAsleep;
		private CBool _isDebris;
		private CBool _initialGuess;
		private TrafficGenDynamicTrafficSetting _dynamicTrafficSetting;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(15)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get => GetProperty(ref _startAsleep);
			set => SetProperty(ref _startAsleep, value);
		}

		[Ordinal(16)] 
		[RED("isDebris")] 
		public CBool IsDebris
		{
			get => GetProperty(ref _isDebris);
			set => SetProperty(ref _isDebris, value);
		}

		[Ordinal(17)] 
		[RED("initialGuess")] 
		public CBool InitialGuess
		{
			get => GetProperty(ref _initialGuess);
			set => SetProperty(ref _initialGuess, value);
		}

		[Ordinal(18)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetProperty(ref _dynamicTrafficSetting);
			set => SetProperty(ref _dynamicTrafficSetting, value);
		}

		[Ordinal(19)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		[Ordinal(20)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetProperty(ref _useMeshNavmeshSettings);
			set => SetProperty(ref _useMeshNavmeshSettings, value);
		}

		public worldDynamicMeshNode()
		{
			_isDebris = true;
			_initialGuess = true;
			_useMeshNavmeshSettings = true;
		}
	}
}
