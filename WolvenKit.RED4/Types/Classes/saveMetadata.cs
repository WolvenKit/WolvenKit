using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class saveMetadata : saveGameMetadata
	{
		[Ordinal(42)] 
		[RED("saveVersion")] 
		public CUInt32 SaveVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(43)] 
		[RED("gameVersion")] 
		public CUInt32 GameVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(44)] 
		[RED("timestampString")] 
		public CString TimestampString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(45)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("userName")] 
		public CString UserName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(47)] 
		[RED("buildID")] 
		public CString BuildID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(48)] 
		[RED("platform")] 
		public CString Platform
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(49)] 
		[RED("censorFlags")] 
		public CString CensorFlags
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(50)] 
		[RED("buildConfiguration")] 
		public CString BuildConfiguration
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(51)] 
		[RED("fileSize")] 
		public CUInt32 FileSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(52)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("isCheckpoint")] 
		public CBool IsCheckpoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(55)] 
		[RED("isStoryMode")] 
		public CBool IsStoryMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("isPointOfNoReturn")] 
		public CBool IsPointOfNoReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("isEndGameSave")] 
		public CBool IsEndGameSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("additionalContentIds")] 
		public CArray<CName> AdditionalContentIds
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public saveMetadata()
		{
			SaveVersion = 263;
			GameVersion = 2120;
			AdditionalContentIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
