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
			get => GetProperty(ref _saveIndex);
			set => SetProperty(ref _saveIndex, value);
		}

		[Ordinal(1)] 
		[RED("saveID")] 
		public CUInt32 SaveID
		{
			get => GetProperty(ref _saveID);
			set => SetProperty(ref _saveID, value);
		}

		[Ordinal(2)] 
		[RED("internalName")] 
		public CString InternalName
		{
			get => GetProperty(ref _internalName);
			set => SetProperty(ref _internalName, value);
		}

		[Ordinal(3)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetProperty(ref _locationName);
			set => SetProperty(ref _locationName, value);
		}

		[Ordinal(4)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(5)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get => GetProperty(ref _lifePath);
			set => SetProperty(ref _lifePath, value);
		}

		[Ordinal(6)] 
		[RED("saveType")] 
		public CEnum<inkSaveType> SaveType
		{
			get => GetProperty(ref _saveType);
			set => SetProperty(ref _saveType, value);
		}

		[Ordinal(7)] 
		[RED("timestamp")] 
		public CUInt64 Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetProperty(ref _playTime);
			set => SetProperty(ref _playTime, value);
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetProperty(ref _playthroughTime);
			set => SetProperty(ref _playthroughTime, value);
		}

		[Ordinal(10)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetProperty(ref _initialLoadingScreenID);
			set => SetProperty(ref _initialLoadingScreenID, value);
		}

		[Ordinal(11)] 
		[RED("level")] 
		public CDouble Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(12)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		public inkSaveMetadataInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
