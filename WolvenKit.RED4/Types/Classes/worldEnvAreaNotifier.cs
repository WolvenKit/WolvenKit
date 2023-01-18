using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEnvAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("env")] 
		public CResourceReference<worldEnvironmentAreaParameters> Env
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(9)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(10)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("weatherStateValues")] 
		public CArray<CBool> WeatherStateValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(12)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldEnvAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player | Enums.TriggerChannel.TC_Environment;
			BlendTimeIn = 3.000000F;
			BlendTimeOut = 3.000000F;
			Params = new() { AreaParameters = new() };
			WeatherStateNames = new();
			WeatherStateValues = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
