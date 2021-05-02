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
			get => GetProperty(ref _saveVersion);
			set => SetProperty(ref _saveVersion, value);
		}

		[Ordinal(42)] 
		[RED("gameVersion")] 
		public CUInt32 GameVersion
		{
			get => GetProperty(ref _gameVersion);
			set => SetProperty(ref _gameVersion, value);
		}

		[Ordinal(43)] 
		[RED("timestampString")] 
		public CString TimestampString
		{
			get => GetProperty(ref _timestampString);
			set => SetProperty(ref _timestampString, value);
		}

		[Ordinal(44)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(45)] 
		[RED("userName")] 
		public CString UserName
		{
			get => GetProperty(ref _userName);
			set => SetProperty(ref _userName, value);
		}

		[Ordinal(46)] 
		[RED("buildID")] 
		public CString BuildID
		{
			get => GetProperty(ref _buildID);
			set => SetProperty(ref _buildID, value);
		}

		[Ordinal(47)] 
		[RED("platform")] 
		public CString Platform
		{
			get => GetProperty(ref _platform);
			set => SetProperty(ref _platform, value);
		}

		[Ordinal(48)] 
		[RED("censorFlags")] 
		public CString CensorFlags
		{
			get => GetProperty(ref _censorFlags);
			set => SetProperty(ref _censorFlags, value);
		}

		[Ordinal(49)] 
		[RED("buildConfiguration")] 
		public CString BuildConfiguration
		{
			get => GetProperty(ref _buildConfiguration);
			set => SetProperty(ref _buildConfiguration, value);
		}

		[Ordinal(50)] 
		[RED("fileSize")] 
		public CUInt32 FileSize
		{
			get => GetProperty(ref _fileSize);
			set => SetProperty(ref _fileSize, value);
		}

		[Ordinal(51)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get => GetProperty(ref _isForced);
			set => SetProperty(ref _isForced, value);
		}

		[Ordinal(52)] 
		[RED("isCheckpoint")] 
		public CBool IsCheckpoint
		{
			get => GetProperty(ref _isCheckpoint);
			set => SetProperty(ref _isCheckpoint, value);
		}

		[Ordinal(53)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetProperty(ref _initialLoadingScreenID);
			set => SetProperty(ref _initialLoadingScreenID, value);
		}

		[Ordinal(54)] 
		[RED("isStoryMode")] 
		public CBool IsStoryMode
		{
			get => GetProperty(ref _isStoryMode);
			set => SetProperty(ref _isStoryMode, value);
		}

		[Ordinal(55)] 
		[RED("isPointOfNoReturn")] 
		public CBool IsPointOfNoReturn
		{
			get => GetProperty(ref _isPointOfNoReturn);
			set => SetProperty(ref _isPointOfNoReturn, value);
		}

		[Ordinal(56)] 
		[RED("isEndGameSave")] 
		public CBool IsEndGameSave
		{
			get => GetProperty(ref _isEndGameSave);
			set => SetProperty(ref _isEndGameSave, value);
		}

		public saveMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
