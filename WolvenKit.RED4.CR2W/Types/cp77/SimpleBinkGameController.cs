using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleBinkGameController : DeviceInkGameControllerBase
	{
		private CBool _playCommonAd;
		private CName _video1Path;
		private CName _video2Path;
		private inkVideoWidgetReference _video1;
		private inkVideoWidgetReference _video2;

		[Ordinal(16)] 
		[RED("playCommonAd")] 
		public CBool PlayCommonAd
		{
			get => GetProperty(ref _playCommonAd);
			set => SetProperty(ref _playCommonAd, value);
		}

		[Ordinal(17)] 
		[RED("Video1Path")] 
		public CName Video1Path
		{
			get => GetProperty(ref _video1Path);
			set => SetProperty(ref _video1Path, value);
		}

		[Ordinal(18)] 
		[RED("Video2Path")] 
		public CName Video2Path
		{
			get => GetProperty(ref _video2Path);
			set => SetProperty(ref _video2Path, value);
		}

		[Ordinal(19)] 
		[RED("Video1")] 
		public inkVideoWidgetReference Video1
		{
			get => GetProperty(ref _video1);
			set => SetProperty(ref _video1, value);
		}

		[Ordinal(20)] 
		[RED("Video2")] 
		public inkVideoWidgetReference Video2
		{
			get => GetProperty(ref _video2);
			set => SetProperty(ref _video2, value);
		}

		public SimpleBinkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
