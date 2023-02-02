using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseInfoLogger : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("showStackTransformsCount")] 
		public CBool ShowStackTransformsCount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("showStackTracksCount")] 
		public CBool ShowStackTracksCount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<CHandle<animPoseInfoLoggerEntry>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<animPoseInfoLoggerEntry>>>();
			set => SetPropertyValue<CArray<CHandle<animPoseInfoLoggerEntry>>>(value);
		}

		public animPoseInfoLogger()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
