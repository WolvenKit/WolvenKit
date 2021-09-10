using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_EquipmentDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("itemEquipped")] 
		public gamebbScriptID_Variant ItemEquipped
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("lastModifiedArea")] 
		public gamebbScriptID_Variant LastModifiedArea
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_EquipmentDef()
		{
			ItemEquipped = new();
			LastModifiedArea = new();
		}
	}
}
