using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotUsageToken : CVariable
	{
		private worldGlobalNodeID _usedSpotId;
		private entEntityID _spotUserId;

		[Ordinal(0)] 
		[RED("usedSpotId")] 
		public worldGlobalNodeID UsedSpotId
		{
			get => GetProperty(ref _usedSpotId);
			set => SetProperty(ref _usedSpotId, value);
		}

		[Ordinal(1)] 
		[RED("spotUserId")] 
		public entEntityID SpotUserId
		{
			get => GetProperty(ref _spotUserId);
			set => SetProperty(ref _spotUserId, value);
		}

		public AISpotUsageToken(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
