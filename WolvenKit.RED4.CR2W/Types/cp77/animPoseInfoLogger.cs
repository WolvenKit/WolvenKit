using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLogger : CVariable
	{
		private CBool _enabled;
		private CBool _showStackTransformsCount;
		private CBool _showStackTracksCount;
		private CArray<CHandle<animPoseInfoLoggerEntry>> _entries;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("showStackTransformsCount")] 
		public CBool ShowStackTransformsCount
		{
			get => GetProperty(ref _showStackTransformsCount);
			set => SetProperty(ref _showStackTransformsCount, value);
		}

		[Ordinal(2)] 
		[RED("showStackTracksCount")] 
		public CBool ShowStackTracksCount
		{
			get => GetProperty(ref _showStackTracksCount);
			set => SetProperty(ref _showStackTracksCount, value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<CHandle<animPoseInfoLoggerEntry>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public animPoseInfoLogger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
