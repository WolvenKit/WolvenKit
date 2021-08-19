using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_PointOfNoReturnRewardScreenDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _rewards;

		[Ordinal(0)] 
		[RED("Rewards")] 
		public gamebbScriptID_Variant Rewards
		{
			get => GetProperty(ref _rewards);
			set => SetProperty(ref _rewards, value);
		}

		public UI_PointOfNoReturnRewardScreenDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
