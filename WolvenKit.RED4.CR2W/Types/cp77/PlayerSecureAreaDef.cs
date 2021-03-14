using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _inside;

		[Ordinal(0)] 
		[RED("inside")] 
		public gamebbScriptID_Bool Inside
		{
			get
			{
				if (_inside == null)
				{
					_inside = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "inside", cr2w, this);
				}
				return _inside;
			}
			set
			{
				if (_inside == value)
				{
					return;
				}
				_inside = value;
				PropertySet(this);
			}
		}

		public PlayerSecureAreaDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
