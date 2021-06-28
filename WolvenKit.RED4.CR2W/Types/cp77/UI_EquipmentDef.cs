using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDef : gamebbScriptDefinition
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

		public UI_EquipmentDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
