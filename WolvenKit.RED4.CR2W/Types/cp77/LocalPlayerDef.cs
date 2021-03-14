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
			get
			{
				if (_insideVehicleForbiddenAreasCount == null)
				{
					_insideVehicleForbiddenAreasCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "InsideVehicleForbiddenAreasCount", cr2w, this);
				}
				return _insideVehicleForbiddenAreasCount;
			}
			set
			{
				if (_insideVehicleForbiddenAreasCount == value)
				{
					return;
				}
				_insideVehicleForbiddenAreasCount = value;
				PropertySet(this);
			}
		}

		public LocalPlayerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
