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
			get
			{
				if (_lastCommand == null)
				{
					_lastCommand = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastCommand", cr2w, this);
				}
				return _lastCommand;
			}
			set
			{
				if (_lastCommand == value)
				{
					return;
				}
				_lastCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastItem")] 
		public gamebbScriptID_Variant LastItem
		{
			get
			{
				if (_lastItem == null)
				{
					_lastItem = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastItem", cr2w, this);
				}
				return _lastItem;
			}
			set
			{
				if (_lastItem == value)
				{
					return;
				}
				_lastItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastIngredients")] 
		public gamebbScriptID_Variant LastIngredients
		{
			get
			{
				if (_lastIngredients == null)
				{
					_lastIngredients = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastIngredients", cr2w, this);
				}
				return _lastIngredients;
			}
			set
			{
				if (_lastIngredients == value)
				{
					return;
				}
				_lastIngredients = value;
				PropertySet(this);
			}
		}

		public UI_CraftingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
