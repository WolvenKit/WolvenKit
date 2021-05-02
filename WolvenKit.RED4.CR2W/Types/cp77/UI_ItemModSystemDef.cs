using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ItemModSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemModSystemUpdated;

		[Ordinal(0)] 
		[RED("ItemModSystemUpdated")] 
		public gamebbScriptID_Variant ItemModSystemUpdated
		{
			get => GetProperty(ref _itemModSystemUpdated);
			set => SetProperty(ref _itemModSystemUpdated, value);
		}

		public UI_ItemModSystemDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
