using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGuardAreaConnectedCommunity : CVariable
	{
		private gameEntityReference _communityArea;
		private CBool _isPrimary;

		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get => GetProperty(ref _communityArea);
			set => SetProperty(ref _communityArea, value);
		}

		[Ordinal(1)] 
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get => GetProperty(ref _isPrimary);
			set => SetProperty(ref _isPrimary, value);
		}

		public AIGuardAreaConnectedCommunity(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
