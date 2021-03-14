using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowLevelUpNotification_NodeType : questIUIManagerNodeType
	{
		private questLevelUpData _levelUpData;

		[Ordinal(0)] 
		[RED("levelUpData")] 
		public questLevelUpData LevelUpData
		{
			get
			{
				if (_levelUpData == null)
				{
					_levelUpData = (questLevelUpData) CR2WTypeManager.Create("questLevelUpData", "levelUpData", cr2w, this);
				}
				return _levelUpData;
			}
			set
			{
				if (_levelUpData == value)
				{
					return;
				}
				_levelUpData = value;
				PropertySet(this);
			}
		}

		public questShowLevelUpNotification_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
