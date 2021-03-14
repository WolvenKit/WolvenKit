using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_SceneScreenDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _animName;

		[Ordinal(0)] 
		[RED("AnimName")] 
		public gamebbScriptID_CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "AnimName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		public UI_SceneScreenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
