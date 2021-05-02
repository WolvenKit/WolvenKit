using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewsFeedDataProvider : IScriptable
	{
		private TweakDBID _newsTitleTweak;
		private TweakDBID _randomNewsFeedPack;

		[Ordinal(0)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get => GetProperty(ref _newsTitleTweak);
			set => SetProperty(ref _newsTitleTweak, value);
		}

		[Ordinal(1)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get => GetProperty(ref _randomNewsFeedPack);
			set => SetProperty(ref _randomNewsFeedPack, value);
		}

		public gameuiNewsFeedDataProvider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
