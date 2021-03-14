using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _projectileCaught;

		[Ordinal(0)] 
		[RED("ProjectileCaught")] 
		public gamebbScriptID_Bool ProjectileCaught
		{
			get
			{
				if (_projectileCaught == null)
				{
					_projectileCaught = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ProjectileCaught", cr2w, this);
				}
				return _projectileCaught;
			}
			set
			{
				if (_projectileCaught == value)
				{
					return;
				}
				_projectileCaught = value;
				PropertySet(this);
			}
		}

		public LeftHandCyberwareDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
