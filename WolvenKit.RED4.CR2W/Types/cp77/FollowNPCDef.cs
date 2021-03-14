using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowNPCDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Vector4 _position;

		[Ordinal(0)] 
		[RED("Position")] 
		public gamebbScriptID_Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "Position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		public FollowNPCDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
