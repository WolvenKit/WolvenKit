using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		private CBool _startCombat;

		[Ordinal(0)] 
		[RED("startCombat")] 
		public CBool StartCombat
		{
			get
			{
				if (_startCombat == null)
				{
					_startCombat = (CBool) CR2WTypeManager.Create("Bool", "startCombat", cr2w, this);
				}
				return _startCombat;
			}
			set
			{
				if (_startCombat == value)
				{
					return;
				}
				_startCombat = value;
				PropertySet(this);
			}
		}

		public questToggleCombatForPlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
