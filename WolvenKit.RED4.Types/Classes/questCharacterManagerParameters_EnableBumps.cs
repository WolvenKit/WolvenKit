using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_EnableBumps : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enable;
		private CEnum<AIinfluenceEBumpPolicy> _policy;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(3)] 
		[RED("policy")] 
		public CEnum<AIinfluenceEBumpPolicy> Policy
		{
			get => GetProperty(ref _policy);
			set => SetProperty(ref _policy, value);
		}

		public questCharacterManagerParameters_EnableBumps()
		{
			_enable = true;
			_policy = new() { Value = Enums.AIinfluenceEBumpPolicy.Lean };
		}
	}
}
