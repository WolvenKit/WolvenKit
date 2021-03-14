using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CompanionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _flatHeadSpawned;

		[Ordinal(0)] 
		[RED("flatHeadSpawned")] 
		public gamebbScriptID_Bool FlatHeadSpawned
		{
			get
			{
				if (_flatHeadSpawned == null)
				{
					_flatHeadSpawned = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "flatHeadSpawned", cr2w, this);
				}
				return _flatHeadSpawned;
			}
			set
			{
				if (_flatHeadSpawned == value)
				{
					return;
				}
				_flatHeadSpawned = value;
				PropertySet(this);
			}
		}

		public UI_CompanionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
