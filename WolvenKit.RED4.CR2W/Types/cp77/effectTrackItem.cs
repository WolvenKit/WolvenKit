using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItem : effectBaseItem
	{
		private CFloat _timeBegin;
		private CFloat _timeDuration;
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("timeBegin")] 
		public CFloat TimeBegin
		{
			get => GetProperty(ref _timeBegin);
			set => SetProperty(ref _timeBegin, value);
		}

		[Ordinal(1)] 
		[RED("timeDuration")] 
		public CFloat TimeDuration
		{
			get => GetProperty(ref _timeDuration);
			set => SetProperty(ref _timeDuration, value);
		}

		[Ordinal(2)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetProperty(ref _ruid);
			set => SetProperty(ref _ruid, value);
		}

		public effectTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
