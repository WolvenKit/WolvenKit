using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LocalPlayerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("InsideVehicleForbiddenAreasCount")] 
		public gamebbScriptID_Int32 InsideVehicleForbiddenAreasCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public LocalPlayerDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
