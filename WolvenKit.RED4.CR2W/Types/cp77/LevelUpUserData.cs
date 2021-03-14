using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpUserData : inkGameNotificationData
	{
		private questLevelUpData _data;

		[Ordinal(6)] 
		[RED("data")] 
		public questLevelUpData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (questLevelUpData) CR2WTypeManager.Create("questLevelUpData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public LevelUpUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
