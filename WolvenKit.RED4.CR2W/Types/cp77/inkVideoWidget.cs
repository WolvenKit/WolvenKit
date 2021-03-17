using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoWidget : inkLeafWidget
	{
		private raRef<Bink> _videoResource;
		private CBool _loop;
		private CName _overriddenPlayerName;
		private CBool _isParallaxEnabled;
		private CBool _prefetchVideo;

		[Ordinal(20)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(21)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		[Ordinal(22)] 
		[RED("overriddenPlayerName")] 
		public CName OverriddenPlayerName
		{
			get => GetProperty(ref _overriddenPlayerName);
			set => SetProperty(ref _overriddenPlayerName, value);
		}

		[Ordinal(23)] 
		[RED("isParallaxEnabled")] 
		public CBool IsParallaxEnabled
		{
			get => GetProperty(ref _isParallaxEnabled);
			set => SetProperty(ref _isParallaxEnabled, value);
		}

		[Ordinal(24)] 
		[RED("prefetchVideo")] 
		public CBool PrefetchVideo
		{
			get => GetProperty(ref _prefetchVideo);
			set => SetProperty(ref _prefetchVideo, value);
		}

		public inkVideoWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
