using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSaveMetadataInfo : IScriptable
	{
		private CInt32 _saveIndex;
		private CUInt32 _saveID;
		private CString _internalName;
		private CString _locationName;
		private CString _trackedQuest;
		private CEnum<inkLifePath> _lifePath;
		private CEnum<inkSaveType> _saveType;
		private CUInt64 _timestamp;
		private CDouble _playTime;
		private CDouble _playthroughTime;
		private CUInt64 _initialLoadingScreenID;
		private CDouble _level;
		private CBool _isValid;

		[Ordinal(0)] 
		[RED("saveIndex")] 
		public CInt32 SaveIndex
		{
			get
			{
				if (_saveIndex == null)
				{
					_saveIndex = (CInt32) CR2WTypeManager.Create("Int32", "saveIndex", cr2w, this);
				}
				return _saveIndex;
			}
			set
			{
				if (_saveIndex == value)
				{
					return;
				}
				_saveIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("saveID")] 
		public CUInt32 SaveID
		{
			get
			{
				if (_saveID == null)
				{
					_saveID = (CUInt32) CR2WTypeManager.Create("Uint32", "saveID", cr2w, this);
				}
				return _saveID;
			}
			set
			{
				if (_saveID == value)
				{
					return;
				}
				_saveID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("internalName")] 
		public CString InternalName
		{
			get
			{
				if (_internalName == null)
				{
					_internalName = (CString) CR2WTypeManager.Create("String", "internalName", cr2w, this);
				}
				return _internalName;
			}
			set
			{
				if (_internalName == value)
				{
					return;
				}
				_internalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (CString) CR2WTypeManager.Create("String", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (CString) CR2WTypeManager.Create("String", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get
			{
				if (_lifePath == null)
				{
					_lifePath = (CEnum<inkLifePath>) CR2WTypeManager.Create("inkLifePath", "lifePath", cr2w, this);
				}
				return _lifePath;
			}
			set
			{
				if (_lifePath == value)
				{
					return;
				}
				_lifePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("saveType")] 
		public CEnum<inkSaveType> SaveType
		{
			get
			{
				if (_saveType == null)
				{
					_saveType = (CEnum<inkSaveType>) CR2WTypeManager.Create("inkSaveType", "saveType", cr2w, this);
				}
				return _saveType;
			}
			set
			{
				if (_saveType == value)
				{
					return;
				}
				_saveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timestamp")] 
		public CUInt64 Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (CUInt64) CR2WTypeManager.Create("Uint64", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get
			{
				if (_playTime == null)
				{
					_playTime = (CDouble) CR2WTypeManager.Create("Double", "playTime", cr2w, this);
				}
				return _playTime;
			}
			set
			{
				if (_playTime == value)
				{
					return;
				}
				_playTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get
			{
				if (_playthroughTime == null)
				{
					_playthroughTime = (CDouble) CR2WTypeManager.Create("Double", "playthroughTime", cr2w, this);
				}
				return _playthroughTime;
			}
			set
			{
				if (_playthroughTime == value)
				{
					return;
				}
				_playthroughTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("level")] 
		public CDouble Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CDouble) CR2WTypeManager.Create("Double", "level", cr2w, this);
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

		[Ordinal(12)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		public inkSaveMetadataInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
