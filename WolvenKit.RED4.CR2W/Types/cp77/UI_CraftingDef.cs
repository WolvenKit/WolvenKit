using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CraftingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _lastCommand;
		private gamebbScriptID_Variant _lastItem;
		private gamebbScriptID_Variant _lastIngredients;

		[Ordinal(0)] 
		[RED("lastCommand")] 
		public gamebbScriptID_Variant LastCommand
		{
			get => GetProperty(ref _lastCommand);
			set => SetProperty(ref _lastCommand, value);
		}

		[Ordinal(1)] 
		[RED("lastItem")] 
		public gamebbScriptID_Variant LastItem
		{
			get => GetProperty(ref _lastItem);
			set => SetProperty(ref _lastItem, value);
		}

		[Ordinal(2)] 
		[RED("lastIngredients")] 
		public gamebbScriptID_Variant LastIngredients
		{
			get => GetProperty(ref _lastIngredients);
			set => SetProperty(ref _lastIngredients, value);
		}

		public UI_CraftingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
