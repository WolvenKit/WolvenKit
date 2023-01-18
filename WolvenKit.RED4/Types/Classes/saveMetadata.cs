using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class saveMetadata : saveGameMetadata
	{
		[Ordinal(41)] 
		[RED("saveVersion")] 
		public CUInt32 SaveVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(42)] 
		[RED("gameVersion")] 
		public CUInt32 GameVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(43)] 
		[RED("timestampString")] 
		public CString TimestampString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(44)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(45)] 
		[RED("userName")] 
		public CString UserName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("buildID")] 
		public CString BuildID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(47)] 
		[RED("platform")] 
		public CString Platform
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(48)] 
		[RED("censorFlags")] 
		public CString CensorFlags
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(49)] 
		[RED("buildConfiguration")] 
		public CString BuildConfiguration
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(50)] 
		[RED("fileSize")] 
		public CUInt32 FileSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(51)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("isCheckpoint")] 
		public CBool IsCheckpoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(54)] 
		[RED("isStoryMode")] 
		public CBool IsStoryMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("isPointOfNoReturn")] 
		public CBool IsPointOfNoReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("isEndGameSave")] 
		public CBool IsEndGameSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public saveMetadata()
		{
			SaveVersion = 224;
			GameVersion = 1610;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
