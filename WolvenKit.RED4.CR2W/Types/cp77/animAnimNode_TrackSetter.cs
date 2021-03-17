using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TrackSetter : animAnimNode_OnePoseInput
	{
		private animNamedTrackIndex _track;
		private animFloatLink _value;

		[Ordinal(12)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetProperty(ref _track);
			set => SetProperty(ref _track, value);
		}

		[Ordinal(13)] 
		[RED("value")] 
		public animFloatLink Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public animAnimNode_TrackSetter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
