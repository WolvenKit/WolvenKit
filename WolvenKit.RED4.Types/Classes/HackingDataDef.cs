using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HackingDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _spreadMap;

		[Ordinal(0)] 
		[RED("SpreadMap")] 
		public gamebbScriptID_Variant SpreadMap
		{
			get => GetProperty(ref _spreadMap);
			set => SetProperty(ref _spreadMap, value);
		}
	}
}
