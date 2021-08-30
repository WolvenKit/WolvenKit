using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEnvDisplaySettingsParams : RedBaseClass
	{
		private CBool _enableInstantAdaptation;
		private CBool _enableGlobalLightingTrajectory;
		private CBool _enableEnvProbeInstantUpdate;
		private CBool _allowEnvProbeUpdate;
		private CBool _allowBloom;
		private CBool _allowColorMod;
		private CBool _allowAntialiasing;
		private CBool _allowGlobalFog;
		private CBool _allowDOF;
		private CBool _allowSSAO;
		private CBool _allowCloudsShadow;
		private CBool _allowWaterShader;
		private CFloat _gamma;

		[Ordinal(0)] 
		[RED("enableInstantAdaptation")] 
		public CBool EnableInstantAdaptation
		{
			get => GetProperty(ref _enableInstantAdaptation);
			set => SetProperty(ref _enableInstantAdaptation, value);
		}

		[Ordinal(1)] 
		[RED("enableGlobalLightingTrajectory")] 
		public CBool EnableGlobalLightingTrajectory
		{
			get => GetProperty(ref _enableGlobalLightingTrajectory);
			set => SetProperty(ref _enableGlobalLightingTrajectory, value);
		}

		[Ordinal(2)] 
		[RED("enableEnvProbeInstantUpdate")] 
		public CBool EnableEnvProbeInstantUpdate
		{
			get => GetProperty(ref _enableEnvProbeInstantUpdate);
			set => SetProperty(ref _enableEnvProbeInstantUpdate, value);
		}

		[Ordinal(3)] 
		[RED("allowEnvProbeUpdate")] 
		public CBool AllowEnvProbeUpdate
		{
			get => GetProperty(ref _allowEnvProbeUpdate);
			set => SetProperty(ref _allowEnvProbeUpdate, value);
		}

		[Ordinal(4)] 
		[RED("allowBloom")] 
		public CBool AllowBloom
		{
			get => GetProperty(ref _allowBloom);
			set => SetProperty(ref _allowBloom, value);
		}

		[Ordinal(5)] 
		[RED("allowColorMod")] 
		public CBool AllowColorMod
		{
			get => GetProperty(ref _allowColorMod);
			set => SetProperty(ref _allowColorMod, value);
		}

		[Ordinal(6)] 
		[RED("allowAntialiasing")] 
		public CBool AllowAntialiasing
		{
			get => GetProperty(ref _allowAntialiasing);
			set => SetProperty(ref _allowAntialiasing, value);
		}

		[Ordinal(7)] 
		[RED("allowGlobalFog")] 
		public CBool AllowGlobalFog
		{
			get => GetProperty(ref _allowGlobalFog);
			set => SetProperty(ref _allowGlobalFog, value);
		}

		[Ordinal(8)] 
		[RED("allowDOF")] 
		public CBool AllowDOF
		{
			get => GetProperty(ref _allowDOF);
			set => SetProperty(ref _allowDOF, value);
		}

		[Ordinal(9)] 
		[RED("allowSSAO")] 
		public CBool AllowSSAO
		{
			get => GetProperty(ref _allowSSAO);
			set => SetProperty(ref _allowSSAO, value);
		}

		[Ordinal(10)] 
		[RED("allowCloudsShadow")] 
		public CBool AllowCloudsShadow
		{
			get => GetProperty(ref _allowCloudsShadow);
			set => SetProperty(ref _allowCloudsShadow, value);
		}

		[Ordinal(11)] 
		[RED("allowWaterShader")] 
		public CBool AllowWaterShader
		{
			get => GetProperty(ref _allowWaterShader);
			set => SetProperty(ref _allowWaterShader, value);
		}

		[Ordinal(12)] 
		[RED("gamma")] 
		public CFloat Gamma
		{
			get => GetProperty(ref _gamma);
			set => SetProperty(ref _gamma, value);
		}

		public CEnvDisplaySettingsParams()
		{
			_allowEnvProbeUpdate = true;
			_allowBloom = true;
			_allowColorMod = true;
			_allowAntialiasing = true;
			_allowGlobalFog = true;
			_allowDOF = true;
			_allowSSAO = true;
			_allowCloudsShadow = true;
			_allowWaterShader = true;
			_gamma = 2.200000F;
		}
	}
}
