using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSaveMetadataInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("saveIndex")] 
		public CInt32 SaveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("saveID")] 
		public CUInt32 SaveID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("internalName")] 
		public CString InternalName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get => GetPropertyValue<CEnum<inkLifePath>>();
			set => SetPropertyValue<CEnum<inkLifePath>>(value);
		}

		[Ordinal(6)] 
		[RED("saveType")] 
		public CEnum<inkSaveType> SaveType
		{
			get => GetPropertyValue<CEnum<inkSaveType>>();
			set => SetPropertyValue<CEnum<inkSaveType>>(value);
		}

		[Ordinal(7)] 
		[RED("timestamp")] 
		public CUInt64 Timestamp
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(10)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(11)] 
		[RED("level")] 
		public CDouble Level
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(12)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkSaveMetadataInfo()
		{
			PlayTime = 0.000000;
			PlaythroughTime = 0.000000;
			Level = 0.000000;
		}
	}
}
