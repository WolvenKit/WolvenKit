using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCompanionCacheDataEvent : redEvent
	{
		private CBool _isPlayerCompanionCached;
		private CFloat _isPlayerCompanionCachedTimeStamp;

		[Ordinal(0)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get => GetProperty(ref _isPlayerCompanionCached);
			set => SetProperty(ref _isPlayerCompanionCached, value);
		}

		[Ordinal(1)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get => GetProperty(ref _isPlayerCompanionCachedTimeStamp);
			set => SetProperty(ref _isPlayerCompanionCachedTimeStamp, value);
		}

		public PlayerCompanionCacheDataEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
