using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NarrativePlateDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _plateData;

		[Ordinal(0)] 
		[RED("PlateData")] 
		public gamebbScriptID_Variant PlateData
		{
			get
			{
				if (_plateData == null)
				{
					_plateData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PlateData", cr2w, this);
				}
				return _plateData;
			}
			set
			{
				if (_plateData == value)
				{
					return;
				}
				_plateData = value;
				PropertySet(this);
			}
		}

		public UI_NarrativePlateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
