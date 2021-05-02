using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_FloatTrack : animPoseInfoLoggerEntry
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

		public animPoseInfoLoggerEntry_FloatTrack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
