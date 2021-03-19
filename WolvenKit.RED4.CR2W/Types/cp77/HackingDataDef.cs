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
			get => GetProperty(ref _spreadMap);
			set => SetProperty(ref _spreadMap, value);
		}

		public HackingDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
