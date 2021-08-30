using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEnvAreaNotifier : worldITriggerAreaNotifer
	{
		private CUInt8 _priority;
		private CFloat _horizontalFadeDistance;
		private CFloat _verticalFadeDistance;
		private CFloat _blendTimeIn;
		private CFloat _blendTimeOut;
		private CResourceReference<worldEnvironmentAreaParameters> _env;
		private WorldRenderAreaSettings _params;
		private CArray<CName> _weatherStateNames;
		private CArray<CBool> _weatherStateValues;

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(4)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get => GetProperty(ref _horizontalFadeDistance);
			set => SetProperty(ref _horizontalFadeDistance, value);
		}

		[Ordinal(5)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get => GetProperty(ref _verticalFadeDistance);
			set => SetProperty(ref _verticalFadeDistance, value);
		}

		[Ordinal(6)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get => GetProperty(ref _blendTimeIn);
			set => SetProperty(ref _blendTimeIn, value);
		}

		[Ordinal(7)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get => GetProperty(ref _blendTimeOut);
			set => SetProperty(ref _blendTimeOut, value);
		}

		[Ordinal(8)] 
		[RED("env")] 
		public CResourceReference<worldEnvironmentAreaParameters> Env
		{
			get => GetProperty(ref _env);
			set => SetProperty(ref _env, value);
		}

		[Ordinal(9)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(10)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get => GetProperty(ref _weatherStateNames);
			set => SetProperty(ref _weatherStateNames, value);
		}

		[Ordinal(11)] 
		[RED("weatherStateValues")] 
		public CArray<CBool> WeatherStateValues
		{
			get => GetProperty(ref _weatherStateValues);
			set => SetProperty(ref _weatherStateValues, value);
		}

		public worldEnvAreaNotifier()
		{
			_blendTimeIn = 3.000000F;
			_blendTimeOut = 3.000000F;
		}
	}
}
