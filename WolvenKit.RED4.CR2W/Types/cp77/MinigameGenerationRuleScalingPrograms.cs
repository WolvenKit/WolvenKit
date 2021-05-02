using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		private CHandle<gameIBlackboard> _bbNetwork;
		private CBool _isOfficerBreach;
		private CBool _isRemoteBreach;
		private CBool _isFirstAttempt;

		[Ordinal(7)] 
		[RED("bbNetwork")] 
		public CHandle<gameIBlackboard> BbNetwork
		{
			get => GetProperty(ref _bbNetwork);
			set => SetProperty(ref _bbNetwork, value);
		}

		[Ordinal(8)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get => GetProperty(ref _isOfficerBreach);
			set => SetProperty(ref _isOfficerBreach, value);
		}

		[Ordinal(9)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get => GetProperty(ref _isRemoteBreach);
			set => SetProperty(ref _isRemoteBreach, value);
		}

		[Ordinal(10)] 
		[RED("isFirstAttempt")] 
		public CBool IsFirstAttempt
		{
			get => GetProperty(ref _isFirstAttempt);
			set => SetProperty(ref _isFirstAttempt, value);
		}

		public MinigameGenerationRuleScalingPrograms(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
