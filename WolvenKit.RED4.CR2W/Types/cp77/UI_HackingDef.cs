using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HackingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _ammoIndicator;

		[Ordinal(0)] 
		[RED("ammoIndicator")] 
		public gamebbScriptID_Bool AmmoIndicator
		{
			get
			{
				if (_ammoIndicator == null)
				{
					_ammoIndicator = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ammoIndicator", cr2w, this);
				}
				return _ammoIndicator;
			}
			set
			{
				if (_ammoIndicator == value)
				{
					return;
				}
				_ammoIndicator = value;
				PropertySet(this);
			}
		}

		public UI_HackingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
