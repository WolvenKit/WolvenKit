using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_VisionModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isEnabled;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public gamebbScriptID_Bool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public UI_VisionModeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
