using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelRewardDisplayData : IDisplayData
	{
		private CInt32 _level;
		private CString _rewardName;
		private CString _description;
		private CName _icon;
		private CHandle<gameUILocalizationDataPackage> _locPackage;

		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rewardName")] 
		public CString RewardName
		{
			get
			{
				if (_rewardName == null)
				{
					_rewardName = (CString) CR2WTypeManager.Create("String", "rewardName", cr2w, this);
				}
				return _rewardName;
			}
			set
			{
				if (_rewardName == value)
				{
					return;
				}
				_rewardName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public CName Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CName) CR2WTypeManager.Create("CName", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("locPackage")] 
		public CHandle<gameUILocalizationDataPackage> LocPackage
		{
			get
			{
				if (_locPackage == null)
				{
					_locPackage = (CHandle<gameUILocalizationDataPackage>) CR2WTypeManager.Create("handle:gameUILocalizationDataPackage", "locPackage", cr2w, this);
				}
				return _locPackage;
			}
			set
			{
				if (_locPackage == value)
				{
					return;
				}
				_locPackage = value;
				PropertySet(this);
			}
		}

		public LevelRewardDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
