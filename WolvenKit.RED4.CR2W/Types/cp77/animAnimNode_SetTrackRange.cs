using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		private CFloat _min;
		private CFloat _max;
		private CFloat _oldMin;
		private CFloat _oldMax;
		private animFloatLink _minLink;
		private animFloatLink _maxLink;
		private animFloatLink _oldMinLink;
		private animFloatLink _oldMaxLink;
		private animNamedTrackIndex _track;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(13)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(14)] 
		[RED("oldMin")] 
		public CFloat OldMin
		{
			get => GetProperty(ref _oldMin);
			set => SetProperty(ref _oldMin, value);
		}

		[Ordinal(15)] 
		[RED("oldMax")] 
		public CFloat OldMax
		{
			get => GetProperty(ref _oldMax);
			set => SetProperty(ref _oldMax, value);
		}

		[Ordinal(16)] 
		[RED("minLink")] 
		public animFloatLink MinLink
		{
			get => GetProperty(ref _minLink);
			set => SetProperty(ref _minLink, value);
		}

		[Ordinal(17)] 
		[RED("maxLink")] 
		public animFloatLink MaxLink
		{
			get => GetProperty(ref _maxLink);
			set => SetProperty(ref _maxLink, value);
		}

		[Ordinal(18)] 
		[RED("oldMinLink")] 
		public animFloatLink OldMinLink
		{
			get => GetProperty(ref _oldMinLink);
			set => SetProperty(ref _oldMinLink, value);
		}

		[Ordinal(19)] 
		[RED("oldMaxLink")] 
		public animFloatLink OldMaxLink
		{
			get => GetProperty(ref _oldMaxLink);
			set => SetProperty(ref _oldMaxLink, value);
		}

		[Ordinal(20)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetProperty(ref _track);
			set => SetProperty(ref _track, value);
		}

		[Ordinal(21)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}

		public animAnimNode_SetTrackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
