using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_EquipmentDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("EquipmentData")] 
		public gamebbScriptID_Variant EquipmentData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("ammoLooted")] 
		public gamebbScriptID_Bool AmmoLooted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_EquipmentDataDef()
		{
			EquipmentData = new gamebbScriptID_Variant();
			UIjailbreakData = new gamebbScriptID_Variant();
			AmmoLooted = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
