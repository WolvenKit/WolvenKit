using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<userSettingsUserSettings> _userSettings;
		private CHandle<userSettingsGroup> _diffSettingsGroup;
		private CHandle<userSettingsGroup> _miscSettingsGroup;
		private CFloat _additiveCameraMovements;
		private CBool _isFastForwardByLine;
		private CString _additiveCameraGroupName;
		private CString _fastForwardGroupName;
		private CString _difficultyPath;
		private CString _miscPath;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("userSettings")] 
		public CHandle<userSettingsUserSettings> UserSettings
		{
			get
			{
				if (_userSettings == null)
				{
					_userSettings = (CHandle<userSettingsUserSettings>) CR2WTypeManager.Create("handle:userSettingsUserSettings", "userSettings", cr2w, this);
				}
				return _userSettings;
			}
			set
			{
				if (_userSettings == value)
				{
					return;
				}
				_userSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("diffSettingsGroup")] 
		public CHandle<userSettingsGroup> DiffSettingsGroup
		{
			get
			{
				if (_diffSettingsGroup == null)
				{
					_diffSettingsGroup = (CHandle<userSettingsGroup>) CR2WTypeManager.Create("handle:userSettingsGroup", "diffSettingsGroup", cr2w, this);
				}
				return _diffSettingsGroup;
			}
			set
			{
				if (_diffSettingsGroup == value)
				{
					return;
				}
				_diffSettingsGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("miscSettingsGroup")] 
		public CHandle<userSettingsGroup> MiscSettingsGroup
		{
			get
			{
				if (_miscSettingsGroup == null)
				{
					_miscSettingsGroup = (CHandle<userSettingsGroup>) CR2WTypeManager.Create("handle:userSettingsGroup", "miscSettingsGroup", cr2w, this);
				}
				return _miscSettingsGroup;
			}
			set
			{
				if (_miscSettingsGroup == value)
				{
					return;
				}
				_miscSettingsGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("additiveCameraMovements")] 
		public CFloat AdditiveCameraMovements
		{
			get
			{
				if (_additiveCameraMovements == null)
				{
					_additiveCameraMovements = (CFloat) CR2WTypeManager.Create("Float", "additiveCameraMovements", cr2w, this);
				}
				return _additiveCameraMovements;
			}
			set
			{
				if (_additiveCameraMovements == value)
				{
					return;
				}
				_additiveCameraMovements = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isFastForwardByLine")] 
		public CBool IsFastForwardByLine
		{
			get
			{
				if (_isFastForwardByLine == null)
				{
					_isFastForwardByLine = (CBool) CR2WTypeManager.Create("Bool", "isFastForwardByLine", cr2w, this);
				}
				return _isFastForwardByLine;
			}
			set
			{
				if (_isFastForwardByLine == value)
				{
					return;
				}
				_isFastForwardByLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("additiveCameraGroupName")] 
		public CString AdditiveCameraGroupName
		{
			get
			{
				if (_additiveCameraGroupName == null)
				{
					_additiveCameraGroupName = (CString) CR2WTypeManager.Create("String", "additiveCameraGroupName", cr2w, this);
				}
				return _additiveCameraGroupName;
			}
			set
			{
				if (_additiveCameraGroupName == value)
				{
					return;
				}
				_additiveCameraGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fastForwardGroupName")] 
		public CString FastForwardGroupName
		{
			get
			{
				if (_fastForwardGroupName == null)
				{
					_fastForwardGroupName = (CString) CR2WTypeManager.Create("String", "fastForwardGroupName", cr2w, this);
				}
				return _fastForwardGroupName;
			}
			set
			{
				if (_fastForwardGroupName == value)
				{
					return;
				}
				_fastForwardGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("difficultyPath")] 
		public CString DifficultyPath
		{
			get
			{
				if (_difficultyPath == null)
				{
					_difficultyPath = (CString) CR2WTypeManager.Create("String", "difficultyPath", cr2w, this);
				}
				return _difficultyPath;
			}
			set
			{
				if (_difficultyPath == value)
				{
					return;
				}
				_difficultyPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("miscPath")] 
		public CString MiscPath
		{
			get
			{
				if (_miscPath == null)
				{
					_miscPath = (CString) CR2WTypeManager.Create("String", "miscPath", cr2w, this);
				}
				return _miscPath;
			}
			set
			{
				if (_miscPath == value)
				{
					return;
				}
				_miscPath = value;
				PropertySet(this);
			}
		}

		public GameplaySettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
