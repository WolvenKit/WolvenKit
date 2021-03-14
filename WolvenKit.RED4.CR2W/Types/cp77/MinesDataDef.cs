using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinesDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Vector4 _currentNormal;

		[Ordinal(0)] 
		[RED("CurrentNormal")] 
		public gamebbScriptID_Vector4 CurrentNormal
		{
			get
			{
				if (_currentNormal == null)
				{
					_currentNormal = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "CurrentNormal", cr2w, this);
				}
				return _currentNormal;
			}
			set
			{
				if (_currentNormal == value)
				{
					return;
				}
				_currentNormal = value;
				PropertySet(this);
			}
		}

		public MinesDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
