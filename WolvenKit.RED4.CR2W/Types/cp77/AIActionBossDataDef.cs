using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionBossDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _excludedWaypointPosition;

		[Ordinal(0)] 
		[RED("excludedWaypointPosition")] 
		public gamebbScriptID_Variant ExcludedWaypointPosition
		{
			get
			{
				if (_excludedWaypointPosition == null)
				{
					_excludedWaypointPosition = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "excludedWaypointPosition", cr2w, this);
				}
				return _excludedWaypointPosition;
			}
			set
			{
				if (_excludedWaypointPosition == value)
				{
					return;
				}
				_excludedWaypointPosition = value;
				PropertySet(this);
			}
		}

		public AIActionBossDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
