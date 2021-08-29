using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseInfoLoggerEntry_FloatTrack : animPoseInfoLoggerEntry
	{
		private animNamedTrackIndex _floatTrack;
		private CBool _showOnlyWhenPositive;

		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(1)] 
		[RED("showOnlyWhenPositive")] 
		public CBool ShowOnlyWhenPositive
		{
			get => GetProperty(ref _showOnlyWhenPositive);
			set => SetProperty(ref _showOnlyWhenPositive, value);
		}
	}
}
