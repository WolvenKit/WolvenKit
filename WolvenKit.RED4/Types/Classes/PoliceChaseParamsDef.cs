using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PoliceChaseParamsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("SearchAreaRadius")] 
		public gamebbScriptID_Float SearchAreaRadius
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(1)] 
		[RED("ChasePlayerDistance")] 
		public gamebbScriptID_Float ChasePlayerDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public PoliceChaseParamsDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
