using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

		[Ordinal(2)] 
		[RED("areaChanged")] 
		public gamebbScriptID_Int32 AreaChanged
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("areaChangedSlotIndex")] 
		public gamebbScriptID_Int32 AreaChangedSlotIndex
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("EquipmentInProgress")] 
		public gamebbScriptID_Bool EquipmentInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_EquipmentDef()
		{
			ItemEquipped = new gamebbScriptID_Variant();
			LastModifiedArea = new gamebbScriptID_Variant();
			AreaChanged = new gamebbScriptID_Int32();
			AreaChangedSlotIndex = new gamebbScriptID_Int32();
			EquipmentInProgress = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
