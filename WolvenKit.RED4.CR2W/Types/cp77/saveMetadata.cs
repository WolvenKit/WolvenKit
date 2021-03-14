using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class saveMetadata : saveGameMetadata
	{
		private CUInt32 _saveVersion;
		private CUInt32 _gameVersion;
		private CString _timestampString;
		private CString _name;
		private CString _userName;
		private CString _buildID;
		private CString _platform;
		private CString _censorFlags;
		private CString _buildConfiguration;
		private CUInt32 _fileSize;
		private CBool _isForced;
		private CBool _isCheckpoint;
		private CUInt64 _initialLoadingScreenID;
		private CBool _isStoryMode;
		private CBool _isPointOfNoReturn;
		private CBool _isEndGameSave;

		[Ordinal(41)] 
		[RED("saveVersion")] 
		public CUInt32 SaveVersion
		{
			get
			{
				if (_saveVersion == null)
				{
					_saveVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "saveVersion", cr2w, this);
				}
				return _saveVersion;
			}
			set
			{
				if (_saveVersion == value)
				{
					return;
				}
				_saveVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("gameVersion")] 
		public CUInt32 GameVersion
		{
			get
			{
				if (_gameVersion == null)
				{
					_gameVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "gameVersion", cr2w, this);
				}
				return _gameVersion;
			}
			set
			{
				if (_gameVersion == value)
				{
					return;
				}
				_gameVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("timestampString")] 
		public CString TimestampString
		{
			get
			{
				if (_timestampString == null)
				{
					_timestampString = (CString) CR2WTypeManager.Create("String", "timestampString", cr2w, this);
				}
				return _timestampString;
			}
			set
			{
				if (_timestampString == value)
				{
					return;
				}
				_timestampString = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("userName")] 
		public CString UserName
		{
			get
			{
				if (_userName == null)
				{
					_userName = (CString) CR2WTypeManager.Create("String", "userName", cr2w, this);
				}
				return _userName;
			}
			set
			{
				if (_userName == value)
				{
					return;
				}
				_userName = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("buildID")] 
		public CString BuildID
		{
			get
			{
				if (_buildID == null)
				{
					_buildID = (CString) CR2WTypeManager.Create("String", "buildID", cr2w, this);
				}
				return _buildID;
			}
			set
			{
				if (_buildID == value)
				{
					return;
				}
				_buildID = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("platform")] 
		public CString Platform
		{
			get
			{
				if (_platform == null)
				{
					_platform = (CString) CR2WTypeManager.Create("String", "platform", cr2w, this);
				}
				return _platform;
			}
			set
			{
				if (_platform == value)
				{
					return;
				}
				_platform = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("censorFlags")] 
		public CString CensorFlags
		{
			get
			{
				if (_censorFlags == null)
				{
					_censorFlags = (CString) CR2WTypeManager.Create("String", "censorFlags", cr2w, this);
				}
				return _censorFlags;
			}
			set
			{
				if (_censorFlags == value)
				{
					return;
				}
				_censorFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("buildConfiguration")] 
		public CString BuildConfiguration
		{
			get
			{
				if (_buildConfiguration == null)
				{
					_buildConfiguration = (CString) CR2WTypeManager.Create("String", "buildConfiguration", cr2w, this);
				}
				return _buildConfiguration;
			}
			set
			{
				if (_buildConfiguration == value)
				{
					return;
				}
				_buildConfiguration = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("fileSize")] 
		public CUInt32 FileSize
		{
			get
			{
				if (_fileSize == null)
				{
					_fileSize = (CUInt32) CR2WTypeManager.Create("Uint32", "fileSize", cr2w, this);
				}
				return _fileSize;
			}
			set
			{
				if (_fileSize == value)
				{
					return;
				}
				_fileSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get
			{
				if (_isForced == null)
				{
					_isForced = (CBool) CR2WTypeManager.Create("Bool", "isForced", cr2w, this);
				}
				return _isForced;
			}
			set
			{
				if (_isForced == value)
				{
					return;
				}
				_isForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("isCheckpoint")] 
		public CBool IsCheckpoint
		{
			get
			{
				if (_isCheckpoint == null)
				{
					_isCheckpoint = (CBool) CR2WTypeManager.Create("Bool", "isCheckpoint", cr2w, this);
				}
				return _isCheckpoint;
			}
			set
			{
				if (_isCheckpoint == value)
				{
					return;
				}
				_isCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get
			{
				if (_initialLoadingScreenID == null)
				{
					_initialLoadingScreenID = (CUInt64) CR2WTypeManager.Create("Uint64", "initialLoadingScreenID", cr2w, this);
				}
				return _initialLoadingScreenID;
			}
			set
			{
				if (_initialLoadingScreenID == value)
				{
					return;
				}
				_initialLoadingScreenID = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("isStoryMode")] 
		public CBool IsStoryMode
		{
			get
			{
				if (_isStoryMode == null)
				{
					_isStoryMode = (CBool) CR2WTypeManager.Create("Bool", "isStoryMode", cr2w, this);
				}
				return _isStoryMode;
			}
			set
			{
				if (_isStoryMode == value)
				{
					return;
				}
				_isStoryMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("isPointOfNoReturn")] 
		public CBool IsPointOfNoReturn
		{
			get
			{
				if (_isPointOfNoReturn == null)
				{
					_isPointOfNoReturn = (CBool) CR2WTypeManager.Create("Bool", "isPointOfNoReturn", cr2w, this);
				}
				return _isPointOfNoReturn;
			}
			set
			{
				if (_isPointOfNoReturn == value)
				{
					return;
				}
				_isPointOfNoReturn = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("isEndGameSave")] 
		public CBool IsEndGameSave
		{
			get
			{
				if (_isEndGameSave == null)
				{
					_isEndGameSave = (CBool) CR2WTypeManager.Create("Bool", "isEndGameSave", cr2w, this);
				}
				return _isEndGameSave;
			}
			set
			{
				if (_isEndGameSave == value)
				{
					return;
				}
				_isEndGameSave = value;
				PropertySet(this);
			}
		}

		public saveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
