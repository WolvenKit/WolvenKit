using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CodexSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _codexUpdated;

		[Ordinal(0)] 
		[RED("CodexUpdated")] 
		public gamebbScriptID_Variant CodexUpdated
		{
			get
			{
				if (_codexUpdated == null)
				{
					_codexUpdated = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "CodexUpdated", cr2w, this);
				}
				return _codexUpdated;
			}
			set
			{
				if (_codexUpdated == value)
				{
					return;
				}
				_codexUpdated = value;
				PropertySet(this);
			}
		}

		public UI_CodexSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
