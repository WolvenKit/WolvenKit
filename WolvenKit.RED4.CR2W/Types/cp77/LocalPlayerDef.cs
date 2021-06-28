using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocalPlayerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _insideVehicleForbiddenAreasCount;

		[Ordinal(0)] 
		[RED("InsideVehicleForbiddenAreasCount")] 
		public gamebbScriptID_Int32 InsideVehicleForbiddenAreasCount
		{
			get => GetProperty(ref _insideVehicleForbiddenAreasCount);
			set => SetProperty(ref _insideVehicleForbiddenAreasCount, value);
		}

		public LocalPlayerDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
