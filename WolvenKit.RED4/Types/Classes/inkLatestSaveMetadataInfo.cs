using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLatestSaveMetadataInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get => GetPropertyValue<CEnum<inkLifePath>>();
			set => SetPropertyValue<CEnum<inkLifePath>>(value);
		}

		[Ordinal(3)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(4)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(5)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(6)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkLatestSaveMetadataInfo()
		{
			PlayTime = 0.000000;
			PlaythroughTime = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
