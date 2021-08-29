using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_EquipmentDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _equipmentData;
		private gamebbScriptID_Variant _uIjailbreakData;
		private gamebbScriptID_Bool _ammoLooted;

		[Ordinal(0)] 
		[RED("EquipmentData")] 
		public gamebbScriptID_Variant EquipmentData
		{
			get => GetProperty(ref _equipmentData);
			set => SetProperty(ref _equipmentData, value);
		}

		[Ordinal(1)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get => GetProperty(ref _uIjailbreakData);
			set => SetProperty(ref _uIjailbreakData, value);
		}

		[Ordinal(2)] 
		[RED("ammoLooted")] 
		public gamebbScriptID_Bool AmmoLooted
		{
			get => GetProperty(ref _ammoLooted);
			set => SetProperty(ref _ammoLooted, value);
		}
	}
}
