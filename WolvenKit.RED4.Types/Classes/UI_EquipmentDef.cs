using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_EquipmentDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemEquipped;
		private gamebbScriptID_Variant _lastModifiedArea;

		[Ordinal(0)] 
		[RED("itemEquipped")] 
		public gamebbScriptID_Variant ItemEquipped
		{
			get => GetProperty(ref _itemEquipped);
			set => SetProperty(ref _itemEquipped, value);
		}

		[Ordinal(1)] 
		[RED("lastModifiedArea")] 
		public gamebbScriptID_Variant LastModifiedArea
		{
			get => GetProperty(ref _lastModifiedArea);
			set => SetProperty(ref _lastModifiedArea, value);
		}
	}
}
