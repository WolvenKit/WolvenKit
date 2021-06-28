using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponentPS : AICommandQueuePS
	{
		private AISpotUsageToken _spotUsageToken;

		[Ordinal(2)] 
		[RED("spotUsageToken")] 
		public AISpotUsageToken SpotUsageToken
		{
			get => GetProperty(ref _spotUsageToken);
			set => SetProperty(ref _spotUsageToken, value);
		}

		public AIHumanComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
