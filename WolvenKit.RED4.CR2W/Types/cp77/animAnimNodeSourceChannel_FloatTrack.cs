using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_FloatTrack : animIAnimNodeSourceChannel_Float
	{
		private animNamedTrackIndex _floatTrack;
		private CBool _useComplementValue;

		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(1)] 
		[RED("useComplementValue")] 
		public CBool UseComplementValue
		{
			get => GetProperty(ref _useComplementValue);
			set => SetProperty(ref _useComplementValue, value);
		}

		public animAnimNodeSourceChannel_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
