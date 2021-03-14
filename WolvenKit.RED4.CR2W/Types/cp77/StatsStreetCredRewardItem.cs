using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsStreetCredRewardItem : inkButtonController
	{
		private inkTextWidgetReference _levelRef;
		private inkImageWidgetReference _iconRef;
		private CHandle<LevelRewardDisplayData> _data;

		[Ordinal(10)] 
		[RED("levelRef")] 
		public inkTextWidgetReference LevelRef
		{
			get
			{
				if (_levelRef == null)
				{
					_levelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelRef", cr2w, this);
				}
				return _levelRef;
			}
			set
			{
				if (_levelRef == value)
				{
					return;
				}
				_levelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get
			{
				if (_iconRef == null)
				{
					_iconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconRef", cr2w, this);
				}
				return _iconRef;
			}
			set
			{
				if (_iconRef == value)
				{
					return;
				}
				_iconRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelRewardDisplayData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<LevelRewardDisplayData>) CR2WTypeManager.Create("handle:LevelRewardDisplayData", "data", cr2w, this);
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

		public StatsStreetCredRewardItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
