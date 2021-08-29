using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocalPlayerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _insideVehicleForbiddenAreasCount;

		[Ordinal(0)] 
		[RED("InsideVehicleForbiddenAreasCount")] 
		public gamebbScriptID_Int32 InsideVehicleForbiddenAreasCount
		{
			get => GetProperty(ref _insideVehicleForbiddenAreasCount);
			set => SetProperty(ref _insideVehicleForbiddenAreasCount, value);
		}
	}
}
