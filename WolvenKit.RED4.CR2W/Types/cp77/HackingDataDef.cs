using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackingDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _spreadMap;

		[Ordinal(0)] 
		[RED("SpreadMap")] 
		public gamebbScriptID_Variant SpreadMap
		{
			get
			{
				if (_spreadMap == null)
				{
					_spreadMap = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "SpreadMap", cr2w, this);
				}
				return _spreadMap;
			}
			set
			{
				if (_spreadMap == value)
				{
					return;
				}
				_spreadMap = value;
				PropertySet(this);
			}
		}

		public HackingDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
