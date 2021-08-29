using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_NarrativePlateDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _plateData;

		[Ordinal(0)] 
		[RED("PlateData")] 
		public gamebbScriptID_Variant PlateData
		{
			get => GetProperty(ref _plateData);
			set => SetProperty(ref _plateData, value);
		}
	}
}
